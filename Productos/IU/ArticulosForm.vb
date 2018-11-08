Public Class ArticulosForm
    Dim operacion_ As String
    Dim indice_ As Integer
    Dim MiArticulo As New ArticuloClass
    Dim rubroCombo_ As Integer


    Public Property operacion() As String

        Get
            Return operacion_
        End Get

        Set(ByVal value As String)
            operacion_ = value
        End Set

    End Property

    Public Property indice() As Integer

        Get
            Return indice_
        End Get
        Set(ByVal value As Integer)
            indice_ = value
        End Set

    End Property

    Public Property rubroCombo() As Integer
        Get
            Return rubroCombo_
        End Get
        Set(ByVal value As Integer)
            rubroCombo_ = value
        End Set
    End Property

    Private Sub CancelarButton_Click(sender As Object, e As EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub AceptarButton_Click(sender As Object, e As EventArgs) Handles AceptarButton.Click
        If operacion_ <> "Añadir" Then
            MiArticulo.Id = CInt(idTextBox.Text)
        End If

        MiArticulo.Descripcion = descTextBox.Text
        MiArticulo.IdRubro = rubroComboBox.SelectedIndex

        Select Case operacion_

            Case "Añadir"
                ArticulosList.InsertarArticulo(MiArticulo)

            Case "Eliminar"
                ArticulosList.EliminarArticulo(MiArticulo)

            Case "Modificar"
                ArticulosList.ActualizarArticulo(MiArticulo)

                ArticulosGrid.DataGridView1.Refresh()

        End Select

        Me.Close()
    End Sub

    Private Sub ArticulosForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'De donde traigo los datos
        rubroComboBox.DataSource = RubrosList.TraerRubros
        'Los valores que quiero mostrar
        rubroComboBox.DisplayMember = "Descripcion"
        rubroComboBox.ValueMember = "Id"

        rubroComboBox.SelectedValue = rubroCombo

        MiArticulo.IdRubro = CInt(rubroComboBox.SelectedValue)
    End Sub
End Class