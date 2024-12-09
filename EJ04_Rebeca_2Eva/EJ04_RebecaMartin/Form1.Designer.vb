<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        DatosTableAdapter = New TabControl()
        TabPage1 = New TabPage()
        btnRegistrar = New Button()
        txtIdR = New TextBox()
        txtNombreR = New TextBox()
        txtApellidosR = New TextBox()
        txtTelefonoR = New TextBox()
        txtEmailR = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        TabPage2 = New TabPage()
        btnActualizar = New Button()
        btnBuscarA = New Button()
        txtIdA = New TextBox()
        txtNombreA = New TextBox()
        txtTelefonoA = New TextBox()
        txtEmailA = New TextBox()
        txtApellidosA = New TextBox()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        TabPage3 = New TabPage()
        btnBuscarE = New Button()
        btnEliminar = New Button()
        txtNombreE = New TextBox()
        txtApellidosE = New TextBox()
        txtTelefonoE = New TextBox()
        txtEmailE = New TextBox()
        txtIdE = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        TabPage4 = New TabPage()
        btnActualizarD = New Button()
        DataGridView1 = New DataGridView()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        DatosTableAdapter.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Silver
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 48)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(257, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(276, 28)
        Label1.TabIndex = 1
        Label1.Text = "Matriculación de alumnos"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Left
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(51, 48)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DatosTableAdapter
        ' 
        DatosTableAdapter.Controls.Add(TabPage1)
        DatosTableAdapter.Controls.Add(TabPage2)
        DatosTableAdapter.Controls.Add(TabPage3)
        DatosTableAdapter.Controls.Add(TabPage4)
        DatosTableAdapter.Dock = DockStyle.Fill
        DatosTableAdapter.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DatosTableAdapter.Location = New Point(0, 48)
        DatosTableAdapter.Name = "DatosTableAdapter"
        DatosTableAdapter.SelectedIndex = 0
        DatosTableAdapter.Size = New Size(800, 402)
        DatosTableAdapter.TabIndex = 1
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnRegistrar)
        TabPage1.Controls.Add(txtIdR)
        TabPage1.Controls.Add(txtNombreR)
        TabPage1.Controls.Add(txtApellidosR)
        TabPage1.Controls.Add(txtTelefonoR)
        TabPage1.Controls.Add(txtEmailR)
        TabPage1.Controls.Add(Label11)
        TabPage1.Controls.Add(Label10)
        TabPage1.Controls.Add(Label9)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 374)
        TabPage1.TabIndex = 0
        TabPage1.Text = "REGISTRAR"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.BackColor = Color.Silver
        btnRegistrar.FlatAppearance.BorderSize = 0
        btnRegistrar.FlatStyle = FlatStyle.Flat
        btnRegistrar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistrar.Location = New Point(234, 289)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(324, 52)
        btnRegistrar.TabIndex = 11
        btnRegistrar.Text = "REGISTRAR"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' txtIdR
        ' 
        txtIdR.Location = New Point(234, 42)
        txtIdR.Name = "txtIdR"
        txtIdR.Size = New Size(324, 23)
        txtIdR.TabIndex = 10
        ' 
        ' txtNombreR
        ' 
        txtNombreR.Location = New Point(234, 88)
        txtNombreR.Name = "txtNombreR"
        txtNombreR.Size = New Size(324, 23)
        txtNombreR.TabIndex = 9
        ' 
        ' txtApellidosR
        ' 
        txtApellidosR.Location = New Point(234, 133)
        txtApellidosR.Name = "txtApellidosR"
        txtApellidosR.Size = New Size(324, 23)
        txtApellidosR.TabIndex = 8
        ' 
        ' txtTelefonoR
        ' 
        txtTelefonoR.Location = New Point(234, 214)
        txtTelefonoR.Name = "txtTelefonoR"
        txtTelefonoR.Size = New Size(324, 23)
        txtTelefonoR.TabIndex = 7
        ' 
        ' txtEmailR
        ' 
        txtEmailR.Location = New Point(234, 172)
        txtEmailR.Name = "txtEmailR"
        txtEmailR.Size = New Size(324, 23)
        txtEmailR.TabIndex = 6
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(38, 35)
        Label11.Name = "Label11"
        Label11.Size = New Size(35, 30)
        Label11.TabIndex = 5
        Label11.Text = "ID"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(38, 81)
        Label10.Name = "Label10"
        Label10.Size = New Size(104, 30)
        Label10.TabIndex = 4
        Label10.Text = "NOMBRE"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(38, 126)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 30)
        Label9.TabIndex = 3
        Label9.Text = "APELLIDOS"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(38, 172)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 30)
        Label8.TabIndex = 2
        Label8.Text = "EMAIL"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(38, 214)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 30)
        Label7.TabIndex = 1
        Label7.Text = "TELEFONO"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnActualizar)
        TabPage2.Controls.Add(btnBuscarA)
        TabPage2.Controls.Add(txtIdA)
        TabPage2.Controls.Add(txtNombreA)
        TabPage2.Controls.Add(txtTelefonoA)
        TabPage2.Controls.Add(txtEmailA)
        TabPage2.Controls.Add(txtApellidosA)
        TabPage2.Controls.Add(Label16)
        TabPage2.Controls.Add(Label15)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(Label12)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(792, 374)
        TabPage2.TabIndex = 1
        TabPage2.Text = "ACTUALIZAR"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.Silver
        btnActualizar.FlatAppearance.BorderSize = 0
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizar.Location = New Point(242, 298)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(324, 52)
        btnActualizar.TabIndex = 17
        btnActualizar.Text = "ACTUALIZAR"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscarA
        ' 
        btnBuscarA.BackColor = Color.Silver
        btnBuscarA.FlatAppearance.BorderSize = 0
        btnBuscarA.FlatStyle = FlatStyle.Flat
        btnBuscarA.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscarA.Location = New Point(613, 34)
        btnBuscarA.Name = "btnBuscarA"
        btnBuscarA.Size = New Size(151, 33)
        btnBuscarA.TabIndex = 16
        btnBuscarA.Text = "BUSCAR"
        btnBuscarA.UseVisualStyleBackColor = False
        ' 
        ' txtIdA
        ' 
        txtIdA.Location = New Point(242, 43)
        txtIdA.Name = "txtIdA"
        txtIdA.Size = New Size(324, 23)
        txtIdA.TabIndex = 15
        ' 
        ' txtNombreA
        ' 
        txtNombreA.Location = New Point(242, 96)
        txtNombreA.Name = "txtNombreA"
        txtNombreA.Size = New Size(324, 23)
        txtNombreA.TabIndex = 14
        ' 
        ' txtTelefonoA
        ' 
        txtTelefonoA.Location = New Point(242, 252)
        txtTelefonoA.Name = "txtTelefonoA"
        txtTelefonoA.Size = New Size(324, 23)
        txtTelefonoA.TabIndex = 13
        ' 
        ' txtEmailA
        ' 
        txtEmailA.Location = New Point(242, 202)
        txtEmailA.Name = "txtEmailA"
        txtEmailA.Size = New Size(324, 23)
        txtEmailA.TabIndex = 12
        ' 
        ' txtApellidosA
        ' 
        txtApellidosA.Location = New Point(242, 150)
        txtApellidosA.Name = "txtApellidosA"
        txtApellidosA.Size = New Size(324, 23)
        txtApellidosA.TabIndex = 11
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(37, 89)
        Label16.Name = "Label16"
        Label16.Size = New Size(104, 30)
        Label16.TabIndex = 10
        Label16.Text = "NOMBRE"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(37, 143)
        Label15.Name = "Label15"
        Label15.Size = New Size(124, 30)
        Label15.TabIndex = 9
        Label15.Text = "APELLIDOS"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(37, 195)
        Label14.Name = "Label14"
        Label14.Size = New Size(77, 30)
        Label14.TabIndex = 8
        Label14.Text = "EMAIL"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(37, 245)
        Label13.Name = "Label13"
        Label13.Size = New Size(118, 30)
        Label13.TabIndex = 7
        Label13.Text = "TELEFONO"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(37, 36)
        Label12.Name = "Label12"
        Label12.Size = New Size(35, 30)
        Label12.TabIndex = 6
        Label12.Text = "ID"
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(btnBuscarE)
        TabPage3.Controls.Add(btnEliminar)
        TabPage3.Controls.Add(txtNombreE)
        TabPage3.Controls.Add(txtApellidosE)
        TabPage3.Controls.Add(txtTelefonoE)
        TabPage3.Controls.Add(txtEmailE)
        TabPage3.Controls.Add(txtIdE)
        TabPage3.Controls.Add(Label6)
        TabPage3.Controls.Add(Label5)
        TabPage3.Controls.Add(Label4)
        TabPage3.Controls.Add(Label3)
        TabPage3.Controls.Add(Label2)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(792, 374)
        TabPage3.TabIndex = 2
        TabPage3.Text = "ELIMINAR"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnBuscarE
        ' 
        btnBuscarE.BackColor = Color.Silver
        btnBuscarE.FlatAppearance.BorderSize = 0
        btnBuscarE.FlatStyle = FlatStyle.Flat
        btnBuscarE.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscarE.Location = New Point(633, 40)
        btnBuscarE.Name = "btnBuscarE"
        btnBuscarE.Size = New Size(151, 33)
        btnBuscarE.TabIndex = 11
        btnBuscarE.Text = "BUSCAR"
        btnBuscarE.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.Silver
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.Location = New Point(279, 295)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(324, 52)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' txtNombreE
        ' 
        txtNombreE.Location = New Point(279, 94)
        txtNombreE.Name = "txtNombreE"
        txtNombreE.Size = New Size(324, 23)
        txtNombreE.TabIndex = 9
        ' 
        ' txtApellidosE
        ' 
        txtApellidosE.Location = New Point(279, 137)
        txtApellidosE.Name = "txtApellidosE"
        txtApellidosE.Size = New Size(324, 23)
        txtApellidosE.TabIndex = 8
        ' 
        ' txtTelefonoE
        ' 
        txtTelefonoE.Location = New Point(279, 224)
        txtTelefonoE.Name = "txtTelefonoE"
        txtTelefonoE.Size = New Size(324, 23)
        txtTelefonoE.TabIndex = 7
        ' 
        ' txtEmailE
        ' 
        txtEmailE.Location = New Point(279, 182)
        txtEmailE.Name = "txtEmailE"
        txtEmailE.Size = New Size(324, 23)
        txtEmailE.TabIndex = 6
        ' 
        ' txtIdE
        ' 
        txtIdE.Location = New Point(279, 47)
        txtIdE.Name = "txtIdE"
        txtIdE.Size = New Size(324, 23)
        txtIdE.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(34, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(124, 30)
        Label6.TabIndex = 4
        Label6.Text = "APELLIDOS"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(34, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 30)
        Label5.TabIndex = 3
        Label5.Text = "EMAIL"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(34, 217)
        Label4.Name = "Label4"
        Label4.Size = New Size(118, 30)
        Label4.TabIndex = 2
        Label4.Text = "TELEFONO"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(34, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 30)
        Label3.TabIndex = 1
        Label3.Text = "NOMBRE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(34, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 30)
        Label2.TabIndex = 0
        Label2.Text = "ID"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(btnActualizarD)
        TabPage4.Controls.Add(DataGridView1)
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(792, 374)
        TabPage4.TabIndex = 3
        TabPage4.Text = "DATOS"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarD
        ' 
        btnActualizarD.BackColor = Color.Silver
        btnActualizarD.FlatAppearance.BorderSize = 0
        btnActualizarD.FlatStyle = FlatStyle.Flat
        btnActualizarD.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizarD.Location = New Point(232, 266)
        btnActualizarD.Name = "btnActualizarD"
        btnActualizarD.Size = New Size(324, 52)
        btnActualizarD.TabIndex = 18
        btnActualizarD.Text = "ACTUALIZAR"
        btnActualizarD.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(786, 368)
        DataGridView1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DatosTableAdapter)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        DatosTableAdapter.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DatosTableAdapter As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnEliminar As Button
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents txtApellidosE As TextBox
    Friend WithEvents txtTelefonoE As TextBox
    Friend WithEvents txtEmailE As TextBox
    Friend WithEvents txtIdE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdR As TextBox
    Friend WithEvents txtNombreR As TextBox
    Friend WithEvents txtApellidosR As TextBox
    Friend WithEvents txtTelefonoR As TextBox
    Friend WithEvents txtEmailR As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBuscarE As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBuscarA As Button
    Friend WithEvents txtIdA As TextBox
    Friend WithEvents txtNombreA As TextBox
    Friend WithEvents txtTelefonoA As TextBox
    Friend WithEvents txtEmailA As TextBox
    Friend WithEvents txtApellidosA As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents btnActualizarD As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
