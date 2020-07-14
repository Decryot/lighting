using System;
using OpenTK.Graphics.OpenGL;

namespace lighting
{
    public class Cube
    {

        public void render()
        {
            GL.Begin(BeginMode.Quads);
            GL.Color3(1.0, 0.0, 0.0);
            // Front
            GL.Normal3(0, 0, 1.0);
            GL.Vertex3(-10, 10, 10);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, -10, 10);
            GL.Vertex3(-10, -10, 10);

            // Back
            GL.Normal3(0, 0, -1.0);
            GL.Vertex3(-10, 10, -10);
            GL.Vertex3(10, 10, -10);
            GL.Vertex3(10, -10, -10);
            GL.Vertex3(-10, -10, -10);


            // Left
            GL.Normal3(-1.0, 0, 0);
            GL.Vertex3(-10, 10, -10);
            GL.Vertex3(-10, 10, 10);
            GL.Vertex3(-10, -10, 10);
            GL.Vertex3(-10, -10, -10);


            // Right
            GL.Normal3(1.0, 0, 0);
            GL.Vertex3(10, 10, -10);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, -10, 10);
            GL.Vertex3(10, -10, -10);


            // Top
            GL.Normal3(0, 1.0, 0);
            GL.Vertex3(-10, 10, -10);
            GL.Vertex3(-10, 10, 10);
            GL.Vertex3(10, 10, 10);
            GL.Vertex3(10, 10, -10);


            // Bottom
            GL.Normal3(0, -1.0, 0);
            GL.Vertex3(-10, -10, -10);
            GL.Vertex3(-10, -10, 10);
            GL.Vertex3(10, -10, 10);
            GL.Vertex3(10, -10, -10);
            GL.End();
        }
    }
}
