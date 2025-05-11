Imports OpenTK
Imports OpenTK.Graphics
Imports OpenTK.Graphics.OpenGL
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class Form1

    Public angle As Single

    Public Structure glCoord
        Public X As Double
        Public Y As Double
        Public Z As Double
    End Structure

    Public Structure glVertex
        Public U As Double
        Public V As Double
    End Structure

    Dim Tunnels(32, 32) As glCoord
    Dim Texcoord(32, 32) As glVertex
    Dim TID As Double
    Dim MÖNSTER As Byte = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        GlControl1.Height = Me.Height
        GlControl1.Width = Me.Width
        init()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Sub init()

        ' Dim w As Integer = GlControl1.Width
        ' Dim h As Integer = GlControl1.Height
        ' GlControl1.MakeCurrent()
        ' GL.MatrixMode(MatrixMode.Projection)
        ' GL.LoadIdentity()
        ' GL.ClearColor(Color.SkyBlue)
        ' GL.Ortho(-w / 2, w / 2, -h / 2, h / 2, -1, 1)
        ' GL.Viewport(0, 0, w, h)
        ' GL.End()
        ' GlControl1.SwapBuffers()

        GL.ClearColor(0.0, 0.0, 0.0, 0)
        GL.Enable(EnableCap.DepthTest)
        GL.Viewport(0, 0, GlControl1.Width, GlControl1.Height)
        Dim aspect As Single = CSng(GlControl1.Width) / GlControl1.Height
        Dim projMat As Matrix4 = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4 * 1, aspect, 0.1, 100.0)



        GL.MatrixMode(MatrixMode.Projection)
        GL.LoadMatrix(projMat)

        GL.MatrixMode(MatrixMode.Modelview)
        GL.LoadIdentity()

        'GL.MatrixMode(MatrixMode.Projection)
        'GL.LoadIdentity()
        ' GLut.Perspective(45.0#, w / h, 1.0#, 100.0#)
        'GL.MatrixMode(MatrixMode.Modelview)
        'GL.LoadIdentity()

        GL.Enable(EnableCap.Texture2D)
        'GL.Enable(EnableCap.Blend)
        'GL.Enable(EnableCap.Lighting)
        'GL.Enable(EnableCap.Light0)
        'GL.Enable(EnableCap.Light1)
        'GL.Enable(EnableCap.DepthTest)
        'GL.Enable(EnableCap.AlphaTest)


        GL.ShadeModel(ShadingModel.Smooth)

        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, MaterialParameter.Specular)
        GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, MaterialParameter.Shininess)
        GL.Material(MaterialFace.Back, MaterialParameter.Specular, MaterialParameter.Specular)
        GL.Enable(EnableCap.Lighting)
        GL.Enable(EnableCap.Light0)
        GL.Enable(EnableCap.DepthTest)
        GL.Enable(EnableCap.ColorMaterial)
        GL.Enable(EnableCap.CullFace)
        GL.CullFace(CullFaceMode.FrontAndBack)


        'GL.Enable(EnableCap.Fog)

        'GL.ColorMaterial(MaterialFace.FrontAndBack, ColorMaterialParameter.Specular)
        'GL.Enable( )
        'GL.Enable(EnableCap.ColorMaterial)


        GL.GenTextures(textures.Length, textures)
        LoadTexture(textures(1), "LÅDA\a1.jpg")
        LoadTexture(textures(2), "LÅDA\a2.jpg")
        LoadTexture(textures(3), "LÅDA\a3.jpg")
        LoadTexture(textures(4), "LÅDA\a4.jpg")

        LoadTexture(textures(5), "LÅDA\a5.jpg")
        LoadTexture(textures(6), "LÅDA\a6.jpg")
        LoadTexture(textures(7), "LÅDA\a78.bmp")
        LoadTexture(textures(8), "LÅDA\Kopia av A7.bmp")


        ' GL.Translate(1, 0, 0)
        ' GL.Scale(6, 6, 6)
        digits()


        GL.NewList(1, ListMode.Compile)

        j(1, 1) = -0.55 'X
        j(1, 2) = -0.6 'Y
        j(1, 3) = -0.25 'Z

        j(2, 1) = 0.55 'X
        j(2, 2) = 0.6 'Y
        j(2, 3) = 0.25 'Z




        låda(1)
        GL.EndList()

        GL.NewList(2, ListMode.Compile)



        j(2, 1) = j(2, 1) + 0.005 'X
        j(2, 2) = j(2, 2) + 0.005 'Y
        j(2, 3) = j(2, 3) + 0.005 'Z

        j(1, 1) = j(1, 1) - j(2, 1) 'X
        j(1, 2) = j(1, 2) - j(2, 2) 'Y
        j(1, 3) = j(1, 3) - j(2, 3) 'Z


        låda2(7)
        GL.EndList()

        'GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, 9729)

        GL.Enable(EnableCap.Texture2D)
        ' GL.TexParameterI(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, OpenTK.Graphics.OpenGL.TextureWrapMode.Repeat)
        'GL.TexParameterI(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, OpenTK.Graphics.OpenGL.TextureWrapMode.Repeat)
        GL.TexEnv(TextureEnvTarget.TextureEnv, TextureEnvParameter.TextureEnvMode, OpenTK.Graphics.OpenGL.TextureEnvMode.Modulate)
        'GL.TexParameterI(TextureTarget.ProxyTexture2D, TextureParameterName.TextureMagFilter, OpenTK.Graphics.OpenGL.TextureMinFilter.Nearest)
        'GL.TexParameterI(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, OpenTK.Graphics.OpenGL.TextureMinFilter.Nearest)



        GlControl1.SwapBuffers()
        Timer1.Enabled = True

    End Sub

 


   

    
    Sub digits()


        GL.Clear(ClearBufferMask.ColorBufferBit Or ClearBufferMask.DepthBufferBit)

        GL.LoadIdentity()






        lampor()



        GL.Translate(0, 0, -5 + Math.Sin(angle / 60) * 4)

        GL.Rotate(15, 0, 0, 1)
        GL.Rotate(angle / 1.1111, 0, 1, 1)
        GL.Rotate(angle / 2.222, 0, 1, 0)
        GL.Rotate(angle / 3.3333, 1, 0, 0)
        GL.Rotate(angle / 4.4444, 0, 1, 0)
        GL.Rotate(angle / 5.5555, 0, 0, 1)







        Dim light_position() As Single = {Math.Sin(angle / 30), Math.Cos(angle / 40), Math.Cos(angle / 50)}

        GL.Light(LightName.Light0, LightParameter.Position, light_position)




        ''''GL.Translate(0, -2, 0)
        angle = DateAndTime.Timer * 30


        GL.BindTexture(TextureTarget.Texture2D, textures(MÖNSTER))

        ' GL.FrontFace(FrontFaceDirection.Ccw)
        ' GL.CullFace(CullFaceMode.Front)
        ' GL.PolygonMode(MaterialFace.Front, PolygonMode.Fill)



        GL.Enable(EnableCap.Blend) 'enable alpha blending
        'ObjectAlpha = 1




        GL.Disable(EnableCap.TextureGenS)
        GL.Disable(EnableCap.TextureGenT)
        GL.Disable(EnableCap.Blend)

        GL.PushMatrix()

        GL.Scale(0.99, 0.99, 0.99)
        GL.CallList(1)

        GL.PopMatrix()






        GL.BlendFunc(BlendingFactorSrc.OneMinusDstColor, BlendingFactorDest.DstAlpha)
        GL.BlendFunc(BlendingFactorSrc.DstAlpha, BlendingFactorDest.One)


        GL.TexGen(TextureCoordName.S, TextureGenParameter.TextureGenMode, 9218)
        GL.TexGen(TextureCoordName.S, TextureGenParameter.TextureGenMode, 9218)
        GL.Enable(EnableCap.TextureGenS)
        GL.Enable(EnableCap.TextureGenT)
        GL.Enable(EnableCap.Blend)

        GL.CullFace(CullFaceMode.Front)
        GL.Enable(EnableCap.CullFace)

        ' GL.CallList(2)


        GL.PopMatrix()
















        GlControl1.SwapBuffers()


    End Sub


    

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        digits()
    End Sub

    Private Sub GlControl1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GlControl1.MouseDown
        End
    End Sub

   

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        MÖNSTER = MÖNSTER + 1


        If MÖNSTER > 3 Then MÖNSTER = 0



    End Sub
End Class
