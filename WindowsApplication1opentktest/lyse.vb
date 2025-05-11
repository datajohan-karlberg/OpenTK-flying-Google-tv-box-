
Imports OpenTK
Imports OpenTK.Graphics
Imports OpenTK.Graphics.OpenGL
Imports OpenTK.Graphics.OpenGL.GL
Imports System.Drawing
Imports System.Drawing.Imaging

Module lyse



    Sub lampor()



        Dim mat_specular() As Single = {1.0F, 1.0F, 1.0F, 1.0F}
        Dim mat_shininess() As Single = {30.0F}
        ' Dim light_position() As Single = {1.0F, 1.0F, 1.0F, 0.0F}

        Dim light_position() As Single = {Math.Sin(Form1.angle / 10), Math.Cos(Form1.angle / 10), Math.Cos(Form1.angle / 10)}
        Dim light_ambient() As Single = {0.3F, 0.3F, 0.5F, 1.0F}

        'GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f)
        'GL.ShadeModel(OpenTK.OpenGL.Enums.ShadingModel.Smooth);

        'GL.Material(OpenTK.OpenGL.Enums.MaterialFace.Front, OpenTK.OpenGL.Enums.MaterialParameter.Specular, mat_specular)
        'GL.Material(OpenTK.OpenGL.Enums.MaterialFace.Front, OpenTK.OpenGL.Enums.MaterialParameter.Shininess, mat_shininess)
        GL.Light(LightName.Light0, LightParameter.Position, light_position)
        GL.Light(LightName.Light0, LightParameter.Ambient, light_ambient)
        GL.Light(LightName.Light0, LightParameter.Diffuse, mat_specular)

        'GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Specular, light_ambient)
        'GL.Material(MaterialFace.FrontAndBack, MaterialParameter.Shininess, light_ambient)
        'GL.Material(MaterialFace.Back, MaterialParameter.Specular, MaterialParameter.Specular)



    End Sub



    Sub lampor2()



        Dim LampPosition(0 To 3) As Single









        GL.PushMatrix()

        LampPosition(0) = 6
        LampPosition(1) = 5
        LampPosition(2) = 0.005
        GL.Translate(LampPosition(0), LampPosition(1), LampPosition(2))
        GL.Light(LightName.Light0, LightParameter.Position, LampPosition((0)))



        LampPosition(0) = 6
        LampPosition(1) = 5
        LampPosition(2) = 2
        GL.Light(LightName.Light0, LightParameter.Ambient, LampPosition((0)))


        LampPosition(0) = 6
        LampPosition(1) = 5
        LampPosition(2) = 2
        GL.Light(LightName.Light0, LightParameter.Diffuse, LampPosition((0)))
        GL.PopMatrix()








    End Sub























End Module
