
Imports OpenTK
Imports OpenTK.Graphics
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing
Imports System.Drawing.Imaging

Module LADDARE





    Sub LoadTexture(ByVal textureId As Integer, ByVal filename As String)
        Dim bmp As New Bitmap(filename)

        Dim data As BitmapData = bmp.LockBits(New Rectangle(0, 0, bmp.Width, bmp.Height), _
                                                System.Drawing.Imaging.ImageLockMode.ReadOnly, _
                                                System.Drawing.Imaging.PixelFormat.Format32bppArgb)

        GL.BindTexture(TextureTarget.Texture2D, textureId)
        GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, bmp.Width, bmp.Height, 0, OpenGL.PixelFormat.Bgra, _
                      PixelType.UnsignedByte, data.Scan0)

        bmp.UnlockBits(data)

        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, TextureMinFilter.Linear)
        GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, TextureMagFilter.Linear)
    End Sub




End Module
