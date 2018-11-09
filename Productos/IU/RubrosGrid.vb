Public Class RubrosGrid

    Private Sub RubroGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MenuForm.Label1.Text = "Productos"
        RubrosCollectionBindingSource.DataSource = RubroList.TraerRubros

        'Si la cantidad de filas es mayor a cero, entonces selecciono la primer fila.
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.Rows(0).Selected = True
        End If

    End Sub

    Private Sub RubrosGrid_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip1.Enabled = True
        Me.Dispose()

    End Sub

    Private Sub Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Salir.Click

        MenuForm.Label1.Text = "Productos"
        MenuForm.ToolStrip1.Enabled = True
        Me.Dispose()

    End Sub

    Private Sub llenarRubroform()

        'Número de fila seleccionado en el datagridview
        Dim fila As Integer = DataGridView1.CurrentRow.Index

        RubroForm.IdText.Text = RubroList.Item(fila).Id
        RubroForm.DescripcionText.Text = RubroList.Item(fila).Descripcion


    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click

        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para modificar.")
            Exit Sub
        End If

        'boton modificar
        RubroForm.operacion = "Modificar"
        RubroForm.Text = "Modificar rubro"
        RubroForm.indice = DataGridView1.CurrentRow.Index

        llenarRubroform()
        RubroForm.Show()

        Dim fila As Integer = DataGridView1.CurrentRow.Index

        'Selecciono nuevamente la fila para que refresque el contenido, sino no muestra la modificación.
        DataGridView1.Rows.Item(fila).Selected = False
        DataGridView1.Rows.Item(fila).Selected = True

    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        RubroForm.operacion = "Agregar"
        RubroForm.Text = "Agregar  Rubro"

        RubroForm.Show()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        'Determina si existen filas en el DataGridView
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay filas para eliminar.")
            Exit Sub
        End If

        RubroForm.operacion = "Eliminar"
        RubroForm.Text = "Eliminar  Rubro"
        RubroForm.indice = DataGridView1.CurrentRow.Index
        'RubroForm.TituloLable1.text = "Eliminar Rubro"

        llenarRubroform()
        RubroForm.Show()
    End Sub

End Class