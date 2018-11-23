'Base Class / Parent Class / Kelas Induk
'Kelas yang mewariskan atribut dan method yang dimiliki ke kelas turunannya
Class BangunDatar
    'Variabel yang merupakan atribut/karakteristik kelas BangunDatar
    'Protected artinya dapat diakses oleh kelas turunannya
    Protected warna As String
    Protected keliling, luas As Double

    'Method atau prosedur untuk mengisi variabel warna dengan nilai parameter warna
    Public Sub SetWarna(ByVal warna As String)
        Me.warna = warna
    End Sub

    'Method atau prosedur untuk menghitung keliling bangun datar
    'Hasil perhitungan keliling disimpan pada variabel keliling
    'Prosedur ini akan didefinisikan ulang berikut dengan perhitungannya pada kelas turunan
    Public Overridable Sub HitungKeliling()
        Console.WriteLine(">> Menghitung Keliling Bangun Datar")
        keliling = 0
    End Sub

    'Method atau prosedur untuk menghitung luas bangun datar
    'Hasil perhitungan luas disimpan pada variabel luas
    'Prosedur adalah abstract method, hanya dideklarasikan di kelas utama...
    'dan akan didefinisikan ulang berikut dengan perhitungannya pada kelas turunan
    Public Overridable Sub HitungLuas()
        Console.WriteLine(">> Menghitung Luas Bangun Datar")
        luas = 0
    End Sub
End Class

'Derived Class / Kelas Turunan
'Kelas PersegiPanjang mewarisi atribut dan method dari kelas Induknya yaitu BangunDatar
Class PersegiPanjang : Inherits BangunDatar
    'Variabel yang merupakan atribut/karakteristik kelas PersegiPanjang'
    Private panjang, lebar As Double

    'Method atau prosedur untuk mengisi variabel panjang dengan nilai parameter panjang
    Public Sub SetPanjang(ByVal panjang As String)
        Me.panjang = panjang
    End Sub

    'Method atau prosedur untuk mengisi variabel lebar dengan nilai parameter lbe
    Public Sub SetLebar(ByVal lbr As String)
        lebar = lbr
    End Sub

    'Overrides: mendefinisikan kembali prosedur yang diturunkan oleh kelas Induk
    'Mendefinisikan kembali prosedur HitungKeliling yang diturunkan kelas BangunDatar
    'Mengisi prosedur HitungKeliling dengan perhitungan keliling persegi panjang
    'Hasil perhitungan disimpan pada variabel keliling yang diturunkan kelas BangunDatar
    'MyBase: digunakan mengacu ke kelas Induk untuk memanggil atribut atau method dari kelas Induk
    Public Overrides Sub HitungKeliling()
        MyBase.HitungKeliling()
        Console.WriteLine("...Proses Hitung Keliling Persegi Panjang" & vbNewLine)
        keliling = (2 * panjang) + (2 * lebar)
    End Sub

    'Mendefinisikan kembali prosedur HitungLuas yang diturunkan kelas BangunDatar
    'Mengisi prosedur HitungLuas dengan perhitungan luas persegi panjang
    'Hasil perhitungan disimpan pada variabel luas yang diturunkan kelas BangunDatar
    'MyBase: digunakan mengacu ke kelas Induk untuk memanggil atribut atau method dari kelas Induk
    Public Overrides Sub HitungLuas()
        MyBase.HitungLuas()
        Console.WriteLine("...Proses Hitung Luas Persegi Panjang" & vbNewLine)
        luas = panjang * lebar
    End Sub

    'Prosedur untuk menampilkan nilai variabel yang diturunkan dari kelas Induk
    'dan variabel dari kelas turunan
    Public Sub TampilkanInfoPersegiPanjang()
        Console.WriteLine(">> Informasi Persegi Panjang")
        Console.WriteLine("Warna = " & warna)
        Console.WriteLine("Panjang = " & panjang)
        Console.WriteLine("Lebar = " & lebar)
        Console.WriteLine("Keliling = " & keliling)
        Console.WriteLine("Luas = " & luas & vbNewLine)
    End Sub
End Class

'Derived Class / Kelas Turunan
'Kelas Lingkaran mewarisi atribut dan method dari kelas Induknya yaitu BangunDatar
Class Lingkaran : Inherits BangunDatar
    Const pi As Double = 3.14149
    Private jariJari As Double

    'Method atau prosedur untuk mengisi variabel jariJari dengan nilai parameter jari2
    Public Sub SetJariJari(ByVal jari2 As Double)
        jariJari = jari2
    End Sub

    'Overrides: mendefinisikan kembali prosedur yang diturunkan oleh kelas Induk
    'Mendefinisikan kembali prosedur HitungKeliling yang diturunkan kelas BangunDatar
    'Mengisi prosedur HitungKeliling dengan perhitungan keliling lingkaran
    'Hasil perhitungan disimpan pada variabel keliling yang diturunkan kelas BangunDatar
    'MyBase: digunakan mengacu ke kelas Induk untuk memanggil atribut atau method dari kelas Induk
    Public Overrides Sub HitungKeliling()
        MyBase.HitungKeliling()
        Console.WriteLine("...Proses Hitung Keliling Lingkaran" & vbNewLine)
        keliling = 2 * pi * jariJari
    End Sub

    'Mendefinisikan kembali prosedur HitungLuas yang diturunkan kelas BangunDatar
    'Mengisi prosedur HitungLuas dengan perhitungan luas lingkaran
    'Hasil perhitungan disimpan pada variabel luas yang diturunkan kelas BangunDatar
    'MyBase: digunakan mengacu ke kelas Induk untuk memanggil atribut atau method dari kelas Induk
    Public Overrides Sub HitungLuas()
        MyBase.HitungLuas()
        Console.WriteLine("...Proses Hitung Luas Lingkaran" & vbNewLine)
        luas = pi * jariJari * jariJari
    End Sub

    'Prosedur untuk menampilkan nilai variabel yang diturunkan dari kelas Induk
    'dan variabel dari kelas turunan
    Public Sub TampilkanInfoLingkaran()
        Console.WriteLine(">> Informasi Lingkaran")
        Console.WriteLine("Warna = " & warna)
        Console.WriteLine("Jari-Jari = " & jariJari)
        Console.WriteLine("Keliling = " & keliling)
        Console.WriteLine("Luas = " & luas & vbNewLine)
    End Sub
End Class

'Kelas utama, berisi prosedur Main
Public Class PewarisanAtauInheritance
    Shared Sub Main()
        'Deklarasi dan inisialisasi objek persegiPanjang1 dari kelas PersegiPanjang
        Dim persegiPanjang1 As PersegiPanjang = New PersegiPanjang()

        'Memanggil prosedur SetWarna dari objek persegiPanjang1
        'Prosedur SetWarna diturunkan dari kelas BangunDatar ke kelas PersegiPanjang...
        'sehingga objek persegiPanjang1 juga dapat memiliki prosedur SetWarna
        persegiPanjang1.SetWarna("Merah")

        'Memanggil prosedur SetPanjang dan SetLebar dari objek persegiPanjang1
        'SetPanjang dan SetLebar adalah prosedur asli dari kelas PersegiPanjang
        persegiPanjang1.SetPanjang(10.6)
        persegiPanjang1.SetLebar(5.4)

        'Memanggil prosedur HitungKeliling dan HitungLuas dari objek persegiPanjang1
        'yang sudah didefinisikan kembali oleh kelas turunan yaitu kelas PersegiPanjang
        persegiPanjang1.HitungKeliling()
        persegiPanjang1.HitungLuas()

        'Memanggil prosedur TampilkanInfoPersegiPanjang dari objek persegiPanjang1
        'Prosedur ini adalah prosedur asli dari kelas PersegiPanjang
        persegiPanjang1.TampilkanInfoPersegiPanjang()

        Console.WriteLine(".............................................." & vbNewLine)

        'Deklarasi dan inisialisasi objek lingkaran1 dari kelas Lingkaran
        Dim lingkaran1 As New Lingkaran()

        'Memanggil prosedur SetWarna dari objek lingkaran1
        'Prosedur SetWarna diturunkan dari kelas BangunDatar ke kelas Lingkaran...
        'sehingga objek lingkaran1 juga dapat memiliki prosedur SetWarna
        lingkaran1.SetWarna("Biru")

        'Memanggil prosedur SetJariJari dari objek lingkaran1
        lingkaran1.SetJariJari(7.5)

        'Memanggil prosedur HitungKeliling dan HitungLuas dari objek lingkaran1
        'yang sudah didefinisikan kembali oleh kelas turunan yaitu kelas Lingkaran
        lingkaran1.HitungKeliling()
        lingkaran1.HitungLuas()

        'Memanggil prosedur TampilkanInfoLingkaran dari objek lingkaran1
        lingkaran1.TampilkanInfoLingkaran()

        Console.ReadLine()
    End Sub
End Class