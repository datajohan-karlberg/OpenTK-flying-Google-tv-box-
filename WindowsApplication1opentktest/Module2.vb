Imports OpenTK
Imports OpenTK.Graphics
Imports OpenTK.Graphics.OpenGL
Imports System.Data.SqlTypes
Imports System.Drawing
Imports System.Drawing.Imaging


Module Module2




    Public j(2, 3) As Single



    Sub låda(ByVal t)



        'smal sida

        GL.BindTexture(TextureTarget.Texture2D, textures(t + 1))

        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PushMatrix()
        'OpenTK.Graphics.OpenGL.GL.Scale(4, 0.1, 1)
        GL.Rotate(180, 1, 0, 0)
        GL.Rotate(180, 0, 0, 1)
        'GL.Rotate(180, 0, 1, 0)
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)



        GL.Begin(BeginMode.Quads)

        GL.Normal3(1.0#, 0.0#, 0.0#)
        '  glColor3d 0.8, 0.8, 0.8
        GL.TexCoord2(1.0#, 1.0#)
        'glVertex3d 1.0, -1.0, -1.0// Top Right Of The Quad  Left
        GL.Vertex3(j(1, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'glVertex3d 1.0, 1.0, -1.0// Top Left Of The Quad  Left
        GL.Vertex3(j(1, 1), j(1, 2), j(2, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'glVertex3d 1.0 ,1.0, 1.0// Bottom Left Of The Quad  Left
        GL.Vertex3(j(1, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(0.0#, 1.0#)
        'glVertex3d 1.0, -1.0, 1.0// Bottom Right Of The Quad  Left
        GL.Vertex3(j(1, 1), j(2, 2), j(1, 3))
        GL.End()

        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PopMatrix()
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)





        'Smal sida 2


        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PushMatrix()
        'OpenTK.Graphics.OpenGL.GL.Scale(4, 0.1, 1)
        ' GL.Rotate(180, 1, 0, 0)
        ' GL.Rotate(90 + 180, 0, 0, 1)
        GL.Rotate(180, 0, 1, 0)
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)


        GL.BindTexture(TextureTarget.Texture2D, textures(t + 0))
        GL.Begin(BeginMode.Quads)

        GL.Normal3(1.0#, 0.0#, 0.0#)
        ' glColor3d 1, 1, 1
        GL.TexCoord3(0.0#, 1.0#, 1)
        'glVertex3d 1.0, -1.0, -1.0// Top Right Of The Quad  Left
        GL.Vertex3(j(2, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(1.0#, 1.0#)
        'glVertex3d 1.0, 1.0, -1.0// Top Left Of The Quad  Left
        GL.Vertex3(j(2, 1), j(2, 2), j(1, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'glVertex3d 1.0 ,1.0, 1.0// Bottom Left Of The Quad  Left
        GL.Vertex3(j(2, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'glVertex3d 1.0, -1.0, 1.0// Bottom Right Of The Quad  Left
        GL.Vertex3(j(2, 1), j(1, 2), j(2, 3))
        GL.End()


        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PopMatrix()
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)

        'Exit Sub

        'front


        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PushMatrix()
        'OpenTK.Graphics.OpenGL.GL.Scale(4, 0.1, 1)
        GL.Rotate(180, 1, 0, 0)
        GL.Rotate(180, 0, 0, 1)
        ' GL.Rotate(180, 0, 1, 0)
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)

        GL.BindTexture(TextureTarget.Texture2D, textures(t + 2))
        GL.Begin(BeginMode.Quads)

        GL.Normal3(0.0#, 0.0#, 1.0#)
        '   glColor3d 1, 1, 1
        GL.TexCoord2(0.0#, 1.0#)
        'glVertex3d -1.0 , -1.0 , 1.0 // Top Right Of The Quad  Top
        GL.Vertex3(j(2, 1), j(2, 2), j(1, 3))
        GL.TexCoord2(1.0#, 1.0#)
        'glVertex3d 1.0, -1.0, 1.0// Top Left Of The Quad  Top
        GL.Vertex3(j(1, 1), j(2, 2), j(1, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'glVertex3d 1.0, 1.0, 1.0// Bottom Left Of The Quad  Top
        GL.Vertex3(j(1, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'glVertex3d -1.0, 1.0, 1.0// Bottom Right Of The Quad  Top
        GL.Vertex3(j(2, 1), j(1, 2), j(1, 3))
        GL.End()




        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PopMatrix()
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)






        'backside


        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PushMatrix()
        'OpenTK.Graphics.OpenGL.GL.Scale(4, 0.1, 1)
        GL.Rotate(180, 1, 0, 0)
        GL.Rotate(180, 0, 0, 1)
        ' GL.Rotate(180, 0, 1, 0)
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)

        GL.BindTexture(TextureTarget.Texture2D, textures(t + 3))
        GL.Begin(BeginMode.Quads)

        ' glColor3d 1, 1, 1
        GL.Normal3(0.0#, 0.0#, -1.0#)
        GL.TexCoord2(1.0#, 1.0#)
        'glVertex3d -1.0,-1.0, -1.0// Top Right Of The Quad  Bottom
        GL.Vertex3(j(2, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'glVertex3d -1.0,1.0,-1.0// Top Left Of The Quad  Bottom
        GL.Vertex3(j(2, 1), j(1, 2), j(2, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'glVertex3d 1.0, 1.0, -1.0// Bottom Left Of The Quad  Bottom
        GL.Vertex3(j(1, 1), j(1, 2), j(2, 3))
        GL.TexCoord2(0.0#, 1.0#)
        'glVertex3d 1.0 ,-1.0 ,-1.0 // Bottom Right Of The Quad  Bottom
        GL.Vertex3(j(1, 1), j(2, 2), j(2, 3))
        GL.End()



        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PopMatrix()
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)





        'top

        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PushMatrix()
        'OpenTK.Graphics.OpenGL.GL.Scale(4, 0.1, 1)
        GL.Rotate(180, 1, 0, 0)
        GL.Rotate(90, 0, 0, 1)
        ' GL.Rotate(180, 0, 1, 0)
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)

        GL.BindTexture(TextureTarget.Texture2D, textures(t + 5))
        GL.Begin(BeginMode.Quads)

        '  glColor3d 1, 1, 1
        GL.Normal3(0.0#, 1.0#, 0.0#)
        GL.TexCoord2(0.0#, 1.0#)
        'glVertex3d -1.0, 1.0, -1.0// Top Right Of The Quad  Front
        GL.Vertex3(j(2, 1), j(1, 2), j(2, 3))
        GL.TexCoord2(1.0#, 1.0#)
        'glVertex3d -1.0, 1.0, 1.0// Top Left Of The Quad  Front
        GL.Vertex3(j(2, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'glVertex3d 1.0, 1.0, 1.0// Bottom Left Of The Quad  Front
        GL.Vertex3(j(1, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'glVertex3d 1.0, 1.0, -1.0// Bottom Right Of The Quad  Front
        GL.Vertex3(j(1, 1), j(1, 2), j(2, 3))
        GL.End()


        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PopMatrix()
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)






        'botten


        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PushMatrix()
        'OpenTK.Graphics.OpenGL.GL.Scale(4, 0.1, 1)
        GL.Rotate(180, 1, 0, 0)
        GL.Rotate(90 + 180, 0, 0, 1)
        ' GL.Rotate(180, 0, 1, 0)
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)


        GL.BindTexture(TextureTarget.Texture2D, textures(t + 4))
        GL.Begin(BeginMode.Quads)

        'olor3d 1, 1, 1
        GL.Normal3(0.0#, -1.0#, 0.0#)
        GL.TexCoord2(0.0#, 0.0#)
        'glVertex3d -1.0, -1.0, -1.0 // Top Right Of The Quad  Back
        GL.Vertex3(j(2, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(0.0#, 1.0#)
        'glVertex3d 1.0, -1.0, -1.0 // Top Left Of The Quad  Back
        GL.Vertex3(j(1, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(1.0#, 1.0#)
        'glVertex3d 1.0, -1.0, 1.0// Bottom Left Of The Quad  Back
        GL.Vertex3(j(1, 1), j(2, 2), j(1, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'glVertex3d -1.0, -1.0, 1.0 // Bottom Right Of The Quad  Back
        GL.Vertex3(j(2, 1), j(2, 2), j(1, 3))
        GL.End()


        GL.MatrixMode(OpenGL.MatrixMode.Texture)
        GL.PopMatrix()
        GL.MatrixMode(OpenGL.MatrixMode.Modelview)


    End Sub



    Sub låda2(ByVal t)





        GL.BindTexture(TextureTarget.Texture2D, textures(t))
        GL.Begin(BeginMode.Quads)

        GL.Normal3(1.0#, 0.0#, 0.0#)
        '  GL.Color3d 0.8, 0.8, 0.8
        GL.TexCoord2(1.0#, 1.0#)
        'GL.Vertex3d 1.0, -1.0, -1.0// Top Right Of The Quad  Left
        GL.Vertex3(j(1, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'GL.Vertex3d 1.0, 1.0, -1.0// Top Left Of The Quad  Left
        GL.Vertex3(j(1, 1), j(1, 2), j(2, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'GL.Vertex3d 1.0 ,1.0, 1.0// Bottom Left Of The Quad  Left
        GL.Vertex3(j(1, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(0.0#, 1.0#)
        'GL.Vertex3d 1.0, -1.0, 1.0// Bottom Right Of The Quad  Left
        GL.Vertex3(j(1, 1), j(2, 2), j(1, 3))
        GL.End()



        GL.BindTexture(TextureTarget.Texture2D, textures(t))
        GL.Begin(BeginMode.Quads)

        GL.Normal3(1.0#, 0.0#, 0.0#)
        ' GL.Color3d 1, 1, 1
        GL.TexCoord3(0.0#, 1.0#, 1)
        'GL.Vertex3d 1.0, -1.0, -1.0// Top Right Of The Quad  Left
        GL.Vertex3(j(2, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(1.0#, 1.0#)
        'GL.Vertex3d 1.0, 1.0, -1.0// Top Left Of The Quad  Left
        GL.Vertex3(j(2, 1), j(2, 2), j(1, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'GL.Vertex3d 1.0 ,1.0, 1.0// Bottom Left Of The Quad  Left
        GL.Vertex3(j(2, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'GL.Vertex3d 1.0, -1.0, 1.0// Bottom Right Of The Quad  Left
        GL.Vertex3(j(2, 1), j(1, 2), j(2, 3))
        GL.End()











        GL.BindTexture(TextureTarget.Texture2D, textures(t))
        GL.Begin(BeginMode.Quads)

        GL.Normal3(0.0#, 0.0#, 1.0#)
        '   GL.Color3d 1, 1, 1
        GL.TexCoord2(0.0#, 1.0#)
        'GL.Vertex3d -1.0 , -1.0 , 1.0 // Top Right Of The Quad  Top
        GL.Vertex3(j(2, 1), j(2, 2), j(1, 3))
        GL.TexCoord2(1.0#, 1.0#)
        'GL.Vertex3d 1.0, -1.0, 1.0// Top Left Of The Quad  Top
        GL.Vertex3(j(1, 1), j(2, 2), j(1, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'GL.Vertex3d 1.0, 1.0, 1.0// Bottom Left Of The Quad  Top
        GL.Vertex3(j(1, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'GL.Vertex3d -1.0, 1.0, 1.0// Bottom Right Of The Quad  Top
        GL.Vertex3(j(2, 1), j(1, 2), j(1, 3))
        GL.End()

        GL.BindTexture(TextureTarget.Texture2D, textures(t))
        GL.Begin(BeginMode.Quads)

        ' GL.Color3d 1, 1, 1
        GL.Normal3(0.0#, 0.0#, -1.0#)
        GL.TexCoord2(1.0#, 1.0#)
        'GL.Vertex3d -1.0,-1.0, -1.0// Top Right Of The Quad  Bottom
        GL.Vertex3(j(2, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'GL.Vertex3d -1.0,1.0,-1.0// Top Left Of The Quad  Bottom
        GL.Vertex3(j(2, 1), j(1, 2), j(2, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'GL.Vertex3d 1.0, 1.0, -1.0// Bottom Left Of The Quad  Bottom
        GL.Vertex3(j(1, 1), j(1, 2), j(2, 3))
        GL.TexCoord2(0.0#, 1.0#)
        'GL.Vertex3d 1.0 ,-1.0 ,-1.0 // Bottom Right Of The Quad  Bottom
        GL.Vertex3(j(1, 1), j(2, 2), j(2, 3))
        GL.End()

        GL.BindTexture(TextureTarget.Texture2D, textures(t))
        GL.Begin(BeginMode.Quads)

        '  GL.Color3d 1, 1, 1
        GL.Normal3(0.0#, 1.0#, 0.0#)
        GL.TexCoord2(0.0#, 1.0#)
        'GL.Vertex3d -1.0, 1.0, -1.0// Top Right Of The Quad  Front
        GL.Vertex3(j(2, 1), j(1, 2), j(2, 3))
        GL.TexCoord2(1.0#, 1.0#)
        'GL.Vertex3d -1.0, 1.0, 1.0// Top Left Of The Quad  Front
        GL.Vertex3(j(2, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'GL.Vertex3d 1.0, 1.0, 1.0// Bottom Left Of The Quad  Front
        GL.Vertex3(j(1, 1), j(1, 2), j(1, 3))
        GL.TexCoord2(0.0#, 0.0#)
        'GL.Vertex3d 1.0, 1.0, -1.0// Bottom Right Of The Quad  Front
        GL.Vertex3(j(1, 1), j(1, 2), j(2, 3))
        GL.End()

        GL.BindTexture(TextureTarget.Texture2D, textures(t))
        GL.Begin(BeginMode.Quads)

        'olor3d 1, 1, 1
        GL.Normal3(0.0#, -1.0#, 0.0#)
        GL.TexCoord2(0.0#, 0.0#)
        'GL.Vertex3d -1.0, -1.0, -1.0 // Top Right Of The Quad  Back
        GL.Vertex3(j(2, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(0.0#, 1.0#)
        'GL.Vertex3d 1.0, -1.0, -1.0 // Top Left Of The Quad  Back
        GL.Vertex3(j(1, 1), j(2, 2), j(2, 3))
        GL.TexCoord2(1.0#, 1.0#)
        'GL.Vertex3d 1.0, -1.0, 1.0// Bottom Left Of The Quad  Back
        GL.Vertex3(j(1, 1), j(2, 2), j(1, 3))
        GL.TexCoord2(1.0#, 0.0#)
        'GL.Vertex3d -1.0, -1.0, 1.0 // Bottom Right Of The Quad  Back
        GL.Vertex3(j(2, 1), j(2, 2), j(1, 3))
        GL.End()





    End Sub




























End Module
