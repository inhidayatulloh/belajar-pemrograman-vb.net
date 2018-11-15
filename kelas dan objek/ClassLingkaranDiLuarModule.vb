Public Class ClassLingkaranDiLuarModule
    Const pi As Double = 3.14149
    Private r As Double

    'Konstruktor dengan satu parameter, yaitu r bertipe Double.
    'Variabel r diisi dengan nilai parameter r.
    Public Sub New(ByVal r As Double)
        Me.r = r
    End Sub

    'Fungsi GetKeliling mengembalikan nilai bertipe Double...
    'hasil perhitungan keliling lingkaran.
    Public Function GetKeliling() As Double
        Return 2 * pi * r
    End Function

    'Fungsi GetLuas mengembalikan nilai bertipe Double...
    'hasil perhitungan luas lingkaran.
    Public Function GetLuas() As Double
        Return pi * r * r
    End Function

    'Gunakan modifier Shared untuk mendefinisikan Main pada kelas
    Shared Sub Main()
        'Deklarasi dan Inisialisasi objek lingkaranKecil dan lingkaranBesar dari kelas ClassLingkaran.
        'Memanggil constructor dengan satu parameter, yaitu Public Sub New(ByVal r As Double).
        Dim lingkaranKecil As ClassLingkaranDiLuarModule = New ClassLingkaranDiLuarModule(10.5)
        Dim lingkaranBesar As ClassLingkaranDiLuarModule = New ClassLingkaranDiLuarModule(89.6)

        'Memanggil fungsi GetKeliling dari objek lingkaranKecil untuk mendapatkan nilai keliling lingkaran.
        'Langsung menampilkan nilai keliling lingkaran tanpa menyimpannya terlebih dahulu ke dalam variabel.
        Console.WriteLine("Keliling lingkaranKecil= " & lingkaranKecil.GetKeliling())

        'Memanggil fungsi GetLuas dari objek lingkaranKecil untuk mendapatkan nilai luas lingkaran.
        'Langsung menampilkan nilai luas lingkaran tanpa menyimpannya terlebih dahulu ke dalam variabel.
        Console.WriteLine("Luas lingkaranKecil= " & lingkaranKecil.GetLuas() & vbNewLine)

        'Memanggil fungsi GetKeliling dari objek lingkaranBesar untuk mendapatkan nilai keliling lingkaran.
        'Langsung menampilkan nilai keliling lingkaran tanpa menyimpannya terlebih dahulu ke dalam variabel.
        Console.WriteLine("Keliling lingkaranBesar= " & lingkaranBesar.GetKeliling().ToString("0.00"))

        'Memanggil fungsi GetLuas dari objek lingkaranBesar untuk mendapatkan nilai luas lingkaran.
        'Langsung menampilkan nilai luas lingkaran tanpa menyimpannya terlebih dahulu ke dalam variabel.
        Console.WriteLine("Luas lingkaranBesar= " & lingkaranBesar.GetLuas().ToString("0.00"))

        Console.ReadLine()
    End Sub
End Class