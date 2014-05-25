using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace OGLtest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new GameWindow())
            {
                game.Load += (sender, e) =>
                    {
                        game.VSync = VSyncMode.On;
                    };
                game.Resize += (sender, e) =>
                    {
                        GL.Viewport(0, 0, game.Width, game.Height);
                    };
                game.UpdateFrame += (sender, e) =>
                    {
                        if (game.Keyboard[Key.Escape])
                        {
                            game.Exit();
                        }
                    };
                game.RenderFrame += (sender, e) =>
                    {
                        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                        GL.MatrixMode(MatrixMode.Projection);
                        GL.LoadIdentity();
                        GL.Ortho(-1.0, 1.0, -1.0, 1.0, 0.0, 4.0);
                        GL.Begin(PrimitiveType.LineLoop);
                        GL.Color3(Color.Red);
                        GL.Vertex2(0.0f, -0.03f);
                        GL.Vertex2(0.02f, -0.03f);
                        GL.Vertex2(0.04f, 0.0f);
                        GL.Vertex2(0.01f, 0.04f);
                        GL.Vertex2(0.02f, 0.4f);
                        GL.Vertex2(0.6f, 0.9f);
                        GL.Vertex2(0.6f, 0.7f);
                        GL.Vertex2(0.2f, 0.35f);
                        GL.Vertex2(0.22f, 0.30f);
                        GL.Vertex2(0.6f, 0.6f);
                        GL.Vertex2(0.6f, 0.4f);
                        GL.Vertex2(0.3f, 0.15f);
                        GL.Vertex2(0.32f, 0.10f);
                        GL.Vertex2(0.6f, 0.3f);
                        GL.Vertex2(0.6f, 0.15f);
                        GL.Vertex2(0.3f, -0.07f);
                        GL.Vertex2(0.3f, -0.9f);
                        GL.Vertex2(0.28f, -0.9f);
                        GL.Vertex2(0.0f, -0.3f);
                        GL.Vertex2(-0.0f, -0.3f);
                        GL.Vertex2(-0.28f, -0.9f);
                        GL.Vertex2(-0.3f, -0.9f);
                        GL.Vertex2(-0.3f, -0.07f);
                        GL.Vertex2(-0.6f, 0.15f);
                        GL.Vertex2(-0.6f, 0.3f);
                        GL.Vertex2(-0.32f, 0.10f);
                        GL.Vertex2(-0.3f, 0.15f);
                        GL.Vertex2(-0.6f, 0.4f);
                        GL.Vertex2(-0.6f, 0.6f);
                        GL.Vertex2(-0.22f, 0.30f);
                        GL.Vertex2(-0.2f, 0.35f);
                        GL.Vertex2(-0.6f, 0.7f);
                        GL.Vertex2(-0.6f, 0.9f);
                        GL.Vertex2(-0.02f, 0.4f);
                        GL.Vertex2(-0.01f, 0.04f);
                        GL.Vertex2(-0.04f, 0.0f);
                        GL.Vertex2(-0.02f, -0.03f);
                        GL.Vertex2(-0.0f, -0.03f);
                        GL.End();

                        game.SwapBuffers();
                    };

                game.Run(60.0);
            }
        }
    }
}
