﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmMostarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnChofer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCkVehiculos = New System.Windows.Forms.Button()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelMenu.SuspendLayout()
        Me.PanelCabecera.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel5.Location = New System.Drawing.Point(0, 296)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 9
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuarios.Location = New System.Drawing.Point(0, 296)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(240, 50)
        Me.btnUsuarios.TabIndex = 8
        Me.btnUsuarios.Text = "USUARIOS"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.btnUsuarios)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.btnVehiculos)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.btnChofer)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.btnCkVehiculos)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(240, 612)
        Me.PanelMenu.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Location = New System.Drawing.Point(0, 240)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 7
        '
        'btnVehiculos
        '
        Me.btnVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVehiculos.FlatAppearance.BorderSize = 0
        Me.btnVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVehiculos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVehiculos.Location = New System.Drawing.Point(0, 240)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(240, 50)
        Me.btnVehiculos.TabIndex = 6
        Me.btnVehiculos.Text = "VEHICULOS"
        Me.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVehiculos.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Location = New System.Drawing.Point(0, 184)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 5
        '
        'btnChofer
        '
        Me.btnChofer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnChofer.FlatAppearance.BorderSize = 0
        Me.btnChofer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChofer.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChofer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnChofer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnChofer.Location = New System.Drawing.Point(0, 184)
        Me.btnChofer.Name = "btnChofer"
        Me.btnChofer.Size = New System.Drawing.Size(240, 50)
        Me.btnChofer.TabIndex = 4
        Me.btnChofer.Text = "CHOFERES"
        Me.btnChofer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnChofer.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Location = New System.Drawing.Point(0, 128)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 3
        '
        'btnCkVehiculos
        '
        Me.btnCkVehiculos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCkVehiculos.FlatAppearance.BorderSize = 0
        Me.btnCkVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCkVehiculos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCkVehiculos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCkVehiculos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCkVehiculos.Location = New System.Drawing.Point(0, 128)
        Me.btnCkVehiculos.Name = "btnCkVehiculos"
        Me.btnCkVehiculos.Size = New System.Drawing.Size(240, 50)
        Me.btnCkVehiculos.TabIndex = 2
        Me.btnCkVehiculos.Text = "CHEQUEO VEHICULO"
        Me.btnCkVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCkVehiculos.UseVisualStyleBackColor = True
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelCabecera.Controls.Add(Me.btnRestaurar)
        Me.PanelCabecera.Controls.Add(Me.btnMinimizar)
        Me.PanelCabecera.Controls.Add(Me.btnMaximizar)
        Me.PanelCabecera.Controls.Add(Me.btnCerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1245, 40)
        Me.PanelCabecera.TabIndex = 3
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(240, 40)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1005, 612)
        Me.PanelContenedor.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.maintenance
        Me.PictureBox1.Location = New System.Drawing.Point(0, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(91, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.Presentacion.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(192, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(45, 47)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.Presentacion.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1163, -1)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Presentacion.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1122, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.Presentacion.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1163, -1)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Presentacion.My.Resources.Resources.Icono_cerrar_FN1
        Me.btnCerrar.Location = New System.Drawing.Point(1205, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 652)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.Text = "MenuPrincipal"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelCabecera.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tmMostarMenu As Timer
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnVehiculos As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnChofer As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCkVehiculos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelContenedor As Panel
End Class
