# voxel_renderer

<img src="https://user-images.githubusercontent.com/105574500/183262741-34cc8f0d-6247-4d95-acfc-a9b7a8fa4778.png" width="800px">
<img src="https://user-images.githubusercontent.com/105574500/183262879-654e271e-33f8-413c-b679-5a89156c8842.png" width="800px">

<h2>Features</h2>
<p>
<ul>
<li>Procedurally generated world using Perlin noise</li>
<li>Ambient and diffuse lighting</li>
<li>Distance fog</li>
<li>Player input/controls</li>
<li>Different "block" types</li>
</ul>
</p>

<h2>Building</h2>
<h3>Windows</h3>
<p>
<ol>
<li>Clone the repo</li>
<li>Create /Libraries/include and /Libraries/lib folders and import the following libraries to them:
<ul>
<li>GLFW - directories: /Libraries/include/GLFW for the .h files and /Libraries/lib for the .lib file</li>
<li>GLAD - directory: /Libraries/include/GLAD</li>
<li>GLM - directory: /Libraries/include/GLM</li>
<li>KHR - directory: /Libraries/include/KHR</li>
</ul>
<p>The stb_image library is included in this repo.</p>
<p>NOTE: Place glad.c in the main directory, and glad.h in /Libraries/include/glad.</p>
</li>
<li>Open the sln or proj file in Visual Studio Community/Enterprise/etc.</li>
<li>Build.</li>
</ol>
 I plan to make the setup easier in the future and include the libraries in the repo.
</p>

<h2>Thanks</h2>
<p>
<ul>
<li>Information regarding Perlin noise: www.scratchapixel.com</li>
<li>Information regarding OpenGL and the libraries used: www.learnopengl.com</li>
</ul>
Both are great sites!
</p>
