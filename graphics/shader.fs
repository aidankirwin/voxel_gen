#version 440 core

out vec4 FragColor;

in vec2 TexCoord;
in vec3 Normal;
in vec4 EyeSpacePosition;
in vec3 FragPos;

uniform sampler2D texture1;
uniform vec3 lightPos;

struct 
{
    vec3 color;
    float density;
} fogParams;

void main()
{
    // Fog paramaters
    fogParams.color = vec3(0.1f, 0.3f, 0.5f);
    fogParams.density = 0.04;

    // Light parameters
    float ambientStrength = 0.5;
    vec3 lightColor = vec3(1.0f, 1.0f, 1.0f);
    vec3 ambient = ambientStrength * lightColor;

    // Texture
    FragColor = texture(texture1, TexCoord);

    // Calculate fog
    float fogCoordinate = abs(EyeSpacePosition.z / EyeSpacePosition.w);
    float result = exp(-pow(fogParams.density * fogCoordinate, 2.0));
    result = 1.0 - clamp(result, 0.0, 1.0);

    // Calculate lighting
    vec3 norm = normalize(Normal);
    vec3 lightDir = normalize(lightPos - FragPos);
    float diff = max(dot(norm, lightDir), 0.0);
    vec3 diffuse = diff * lightColor;

    vec3 light = (ambient + diffuse);

    // Apply light
    FragColor = FragColor * vec4(light, 1.0);

    // Apply fog
    FragColor = mix(FragColor, vec4(fogParams.color, 1.0), result);
}