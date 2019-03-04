Public Class mantenimentosVehiculos
    Private Sub VehiculoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VehiculoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VehiculoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Chequeo_de_VehiculosDataSet)

    End Sub

    Private Sub mantenimentosVehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Chequeo_de_VehiculosDataSet.Vehiculo' Puede moverla o quitarla según sea necesario.
        Me.VehiculoTableAdapter.Fill(Me.Chequeo_de_VehiculosDataSet.Vehiculo)

    End Sub
End Class