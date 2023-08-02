Imports System.Diagnostics.Eventing
Imports System.IO

Public Class Form1
    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles SelFile.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.Vista.Rows.Clear()
            Me.Vista.Refresh()
            Dim ruta As String
            ruta = OpenFileDialog1.FileName
            Dim TotalLineas = File.ReadAllLines(ruta).Length

            Dim fichero As New FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
            Dim leerLWD As StreamReader = New StreamReader(fichero)
            'Dim line As String
            Dim ultimo, CountL, CountF As Integer
            Dim line, lineArray() As String
            Dim Control As Boolean = True
            Dim fila As String() = New String() {"1", "2", "0", "0", "0"}


            Me.Archivo.Text = ruta

            CountL = 0
            CountF = 1
            line = leerLWD.ReadLine()                                   'Primera Linea siempre vacia
            While (Control)     'COntrol WHILE General

                While (Control)
                    line = leerLWD.ReadLine()
                    CountL += 1
                    If (CountL >= (TotalLineas - 1)) Then
                        Control = False
                        Exit While
                    End If

                    If (line.Contains("Point")) Then                    'Se ubica cabecera de datos
                        line = leerLWD.ReadLine()                       'se ubica unidades de cabecera
                        line = leerLWD.ReadLine()                       'se ubica separador de cabecera
                        line = leerLWD.ReadLine()                       'se ubica datos golpe LWD
                        CountL += 3
                        If (line <> Nothing) Then
                            ultimo = -1
                            lineArray = line.Split()                         'convertimos linea en array
                            For i As Integer = 0 To lineArray.Length - 1     'Limpiamos espacios vacios
                                If lineArray(i) <> "" Then
                                    ultimo += 1
                                    lineArray(ultimo) = lineArray(i)
                                End If
                            Next
                            fila(0) = CountF
                            fila(1) = lineArray(6)
                            fila(2) = lineArray(7)
                            fila(3) = 0
                            fila(4) = 0
                            CountF += 1
                        Else
                            fila = New String() {CountF, "No Data", "No Data", " - ", " - "}
                            CountF += 1
                        End If

                        Exit While
                    End If
                End While

                If (Control = True) Then
                    Me.Vista.Rows.Add(fila)
                End If

            End While 'WHILE GENERAL

            leerLWD.Close()
            fichero.Close()
            Me.UpdateFile.Enabled = True
        End If

        If (Me.Vista.Rows.Count = 2) And (Me.Vista.Rows(0).Cells(1).Value = "No Data") Then
            MessageBox.Show("No presenta informacion")
        End If

        Me.Vista.Columns(3).DefaultCellStyle.Format = "n0"
        Me.Vista.Columns(3).ValueType = GetType(Integer)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UpdateFile.Click
        Dim linea, ruta, nombre, carpeta, lineArray(30), filas, Km, SubKm, GPS(3), SInicio As String
        Dim lat0, lat1, long0, long1 As String
        Dim lati0, longi0, lati1, longi1, Pinicio As Double
        Dim distancia As Double
        Const tierra As Double = 6378.137
        Dim Punto As Boolean = False
        Dim ultimo, CountF, Dist As Integer
        long0 = ""


        ruta = Me.Archivo.Text
        filas = Me.Vista.Rows.Count - 1         'Numero filas datagridview
        CountF = 0                              'Contador filas datagridview
        lat0 = "primero"

        nombre = System.IO.Path.GetFileName(ruta)
        carpeta = System.IO.Path.GetDirectoryName(ruta)
        carpeta &= "\BACKUP"
        nombre = carpeta + "\" + nombre

        If (Not System.IO.Directory.Exists(carpeta)) Then           'CREAR CARPETA BACKUP
            System.IO.Directory.CreateDirectory(carpeta)
            'MessageBox.Show("Creado 1ra vez")
        End If

        If (System.IO.File.Exists(nombre)) Then                     'BORRAR ARCHIVO DENTRO DE BACKUP
            System.IO.File.Delete(nombre)
        End If

        If filas = 0 Then
            MessageBox.Show("Error filas para actualizar")
            Exit Sub
        End If



        Dim Lectura As New FileStream(ruta, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.None)
        Dim Escritura As New FileStream(nombre, IO.FileMode.OpenOrCreate, IO.FileAccess.Write, IO.FileShare.None)
        Dim leerLWD As StreamReader = New StreamReader(Lectura)

        Using EscribeLWD As StreamWriter = New StreamWriter(Escritura)
            Do Until leerLWD.EndOfStream            'Leer todo el archivo hasta el final
                linea = leerLWD.ReadLine()

                If linea.Contains("Point") Then
                    linea &= "    Dist"
                End If

                If linea.Contains("-----") Then
                    linea &= " -------"
                End If

                If Punto Then                                   'Si Punto = True
                    If (linea = Nothing) Then                   'No hay datos
                        Punto = False                           'No hay datos, continua siguiente linea
                        CountF += 1
                    ElseIf (lat0 = "primero") Then

                        ultimo = -1
                        lineArray = linea.Split()                         'convertimos linea en array
                        For i As Integer = 0 To lineArray.Length - 1      'Limpiamos espacios vacios
                            If lineArray(i) <> "" Then
                                ultimo += 1
                                lineArray(ultimo) = lineArray(i)
                            End If
                        Next
                        lat0 = lineArray(6)                                 'Primer coordenada GPS Latitud
                        long0 = lineArray(7)                                'Primer coordenada GPS Longitud

                        If (lat0.Length < 9) And (long0.Length < 10) Then
                            lat0 = "0000.0000"
                            long0 = "00000.0000"
                        End If
                        Erase lineArray

                        Km = Me.Vista.Rows(CountF).Cells(3).Value           'Capturamos Punto inicio 
                        SubKm = Me.Vista.Rows(CountF).Cells(4).Value        'Capturamos Punto inicio
                        linea &= "  " + Km + "+" + SubKm                     'Agregamos Punto inicio al archivo LWD
                        Pinicio = Convert.ToInt32(Km) * 1000
                        Pinicio += Convert.ToInt32(SubKm)

                    Else
                        ultimo = -1
                        lineArray = linea.Split()                         'convertimos linea en array
                        For i As Integer = 0 To lineArray.Length - 1      'Limpiamos espacios vacios
                            If lineArray(i) <> "" Then
                                ultimo += 1
                                lineArray(ultimo) = lineArray(i)
                            End If
                        Next
                        lat1 = lineArray(6)
                        long1 = lineArray(7)
                        If (lat1.Length < 9) And (long1.Length < 10) Then
                            lat1 = "0000.0000"
                            long1 = "00000.0000"
                        End If
                        lineArray = Nothing

                        GPS(0) = lat0.Substring(0, (lat0.Length - 7))         'grados Latitud 0
                        GPS(1) = lat0.Substring(lat0.Length - 7)              'minutos Latitud 0
                        GPS(2) = long0.Substring(0, (long0.Length - 7))       'grados Longitud 0
                        GPS(3) = long0.Substring(long0.Length - 7)            'minutos Longitud 0

                        lati0 = (Math.Abs(Convert.ToInt32(GPS(0))) + (Convert.ToDecimal(GPS(1) / 60))) * -1
                        longi0 = (Math.Abs(Convert.ToInt32(GPS(2))) + (Convert.ToDecimal(GPS(3) / 60))) * -1
                        lati0 = (lati0 * Math.PI) / 180
                        longi0 = (longi0 * Math.PI) / 180

                        GPS(0) = lat1.Substring(0, (lat1.Length - 7))         'grados Latitud 1
                        GPS(1) = lat1.Substring(lat1.Length - 7)              'minutos Latitud 1
                        GPS(2) = long1.Substring(0, (long1.Length - 7))       'grados Longitud 1
                        GPS(3) = long1.Substring(long1.Length - 7)            'minutos Longitud 1

                        lati1 = (Math.Abs(Convert.ToInt32(GPS(0))) + (Convert.ToDecimal(GPS(1) / 60))) * -1
                        longi1 = (Math.Abs(Convert.ToInt32(GPS(2))) + (Convert.ToDecimal(GPS(3) / 60))) * -1

                        lati1 = (lati1 * Math.PI) / 180
                        longi1 = (longi1 * Math.PI) / 180

                        lat0 = lat1                 'Actualizando valor anterior Latitud
                        long0 = long1               'Actualizando valor anterior Longitud

                        If ((lati0 = lati1) And (longi0 = longi1)) Then
                            distancia = 0
                        Else
                            distancia = Math.Acos(Math.Cos(lati0) * Math.Cos(lati1) * Math.Cos(longi1 - longi0) + Math.Sin(lati0) * Math.Sin(lati1))
                            distancia *= tierra * 1000
                            distancia = Convert.ToInt32(distancia)
                        End If

                        Dist = 0                    'Redondeo a la centena
                        Dist = distancia Mod 100
                        distancia -= Dist
                        If (Dist > 50) Then
                            distancia += 100
                        End If

                        If (distancia > 5000) Then          'Actualizamos Progresiva
                            distancia = Pinicio
                        Else
                            distancia += Pinicio
                            Pinicio = distancia
                        End If
                        SInicio = Convert.ToString(distancia)

                        Select Case SInicio.Length
                            Case 6
                                SInicio = SInicio.Substring(0, 3) + "+" + SInicio.Substring(3)
                            Case 5
                                SInicio = SInicio.Substring(0, 2) + "+" + SInicio.Substring(2)
                            Case 4
                                SInicio = SInicio.Substring(0, 1) + "+" + SInicio.Substring(1)
                            Case 3
                                SInicio = "0+" + SInicio
                            Case 2
                                SInicio &= "+0"
                            Case 1
                                SInicio &= "+0"
                            Case Else
                                SInicio &= "+0"
                        End Select


                        linea &= "  " + SInicio
                        'MessageBox.Show(distancia)
                    End If
                End If

                EscribeLWD.WriteLine(linea)
                If linea.Contains("-----") Then
                    Punto = True
                    lat0 = "primero"

                End If
                '...
            Loop
        End Using

        leerLWD.Close()
        Lectura.Close()
        Escritura.Close()

        MessageBox.Show("Backup LWD Terminado")
    End Sub
End Class
