using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace lighting
{
    public class Game : GameWindow
    {
        Cube cube;
        public Game(int width, int height, string title)
            : base(width,height,GraphicsMode.Default,title) {
            cube = new Cube();
            start();
        }

        void start() {
            GL.Translate(0, 0, -55);
            RenderFrame += render;
            Resize += resize;
            Load += load;

            Run(60);
        }

        private void load(object sender, EventArgs e) {
            GL.ClearColor(0, 0, 0, 0);
            GL.Enable(EnableCap.DepthTest);

            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.ColorMaterial);
        }

        private void resize(object sender, EventArgs e) {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();

            Matrix4 perspectiveMatrix =
                Matrix4.CreatePerspectiveFieldOfView(1, Width / Height, 1.0f, 1000.0f);
            GL.LoadMatrix(ref perspectiveMatrix);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.End();
        }

        private void render(object sender, FrameEventArgs e) {
            GL.Rotate(1,0, -10,0);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            // this is our lighting
            float[] lightPos = { 10f, 10, -20f };
            float[] lightDiffuse = { .15f, .1f, .1f };
            float[] lightAmbient = { .5f,.5f,100 };
            float[] specular = { 1f, 1f, 1f };

            GL.Light(LightName.Light0, LightParameter.Position, lightPos);
            GL.Light(LightName.Light0, LightParameter.Diffuse, lightDiffuse);
            GL.Light(LightName.Light0, LightParameter.Ambient, lightAmbient);
            GL.Light(LightName.Light0, LightParameter.LinearAttenuation, specular);

            GL.Enable(EnableCap.Light0);

            cube.render();
            SwapBuffers();
        }
    }
}
