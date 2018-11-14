Module ModuleProsedurFungsiDanEnkapsulasiPadaKelas
    'Contoh mendefinisikan kelas PersegiEmpat yang memiliki dua atribut, dua prosedur, dan satu fungsi.
    Class PersegiEmpat
        'Atribut berupa variabel panjang dan lebar bertipe data Integer.
        'Variabel diberikan modifier Private artinya hanya dapat diakses dari dalam tempat di mana dideklarasikan.
        'Dalam hal ini, variabel panjang dan lebar hanya dapat dipanggi/diakses dari dalam kelas PersegiEmpat.
        'Ini adalah contoh Enkapsulasi/Encapsulation yang mana variabel panjang dan lebar hanya dapat dipanggil/...
        'diakses/diubah nilainya dari luar tempat dideklarasikan melalui prosedur/fungsi dengan modifier Public,...
        'dalam hal ini SetPanjang, SetLebar dan GetLuas.
        Private panjang As Integer
        Private lebar As Integer

        'Prosedur SetPanjang memiliki satu parameter, yaitu p bertipe Integer.
        'ByVal merupakan modifier untuk melewatkan argument melalui parameter pada prosedur/fungsi 
        'dengan tidak mengijinkan prosedur/fungsi melakukan perubahan pada nilai variabel yang mendasari argument.
        'Variabel panjang diisi oleh nilai argument yang dilewatkan melalui parameter p.
        Public Sub SetPanjang(ByVal p As Integer)
            panjang = p
        End Sub

        'Prosedur SetLebar memiliki satu parameter, yaitu lebar bertipe Integer.
        'Nama parameter boleh sama dengan nama variabel dari kelas, yaitu lebar.
        'Untuk membedakan variabel lebar dari kelas dan parameter lebar digunakan Me.lebar.
        'Me menunjuk pada objek dari kelas yang sedang dieksekusi / kelas di mana variabel lebar berada.
        Public Sub SetLebar(ByVal lebar As Integer)
            Me.lebar = lebar
        End Sub

        'Fungsi GetLuas tidak memiliki parameter dan mengembalikan nilai bertipe Integer.
        'Nilai yang dikembalikan merupakan hasil perkalian nilai pada variabel panjang dan lebar.
        Public Function GetLuas() As Integer
            Return panjang * lebar
        End Function
    End Class

    Sub Main()
        'Deklarasi dan inisialisasi objek persegiEmpatA dan persegiEmpatB dari kelas PersegiEmpat.
        'Objek akan memiliki atribut dan metode/operasi (jika ada) dari kelas PersegiEmpat.
        Dim persegiEmpatA As PersegiEmpat = New PersegiEmpat()
        Dim persegiEmpatB As PersegiEmpat = New PersegiEmpat()

        'Deklarasi variabel luasPersegiEmpat bertipe data Integer.
        Dim luasPersegiEmpat As Integer

        'Mengisi nilai pada variabel panjang dan lebar dari objek persegiEmpatA...
        'dengan cara memanggil prosedur SetPanjang yang diisi argument bernilai 5... 
        'dan SetLebar yang diisi argument bernilai 3.
        'Tidak dapat mengisi nilai ke variabel secara langsung dengan memanggil 
        'persegiEmpatA.panjang = 5 dan persegiEmpatA.lebar = 3 dikarenakan...
        'variabel panjang dan lebar memiliki modifier Private.
        persegiEmpatA.SetPanjang(5)
        persegiEmpatA.SetLebar(3)

        'Mengisi nilai pada variabel panjang dan lebar dari objek persegiEmpatB...
        'dengan cara memanggil prosedur SetPanjang yang diisi argument bernilai 4... 
        'dan SetLebar yang diisi argument bernilai 4.
        'Tidak dapat mengisi nilai ke variabel secara langsung dengan memanggil 
        'persegiEmpatB.panjang = 5 dan persegiEmpatB.lebar = 3 dikarenakan...
        'variabel panjang dan lebar memiliki modifier Private.
        persegiEmpatB.SetPanjang(4)
        persegiEmpatB.SetLebar(4)

        'Memanggil fungsi GetLuas dari objek persegiEmpatA dan persegiEmpatB untuk mendapatkan...
        'hasil perkalian nilai variabel panjang dan lebar dari masing-masing objek.
        'Hasil perkalian kemudian disimpan di variabel luasPersegiEmpat.
        'Selanjutnya, menampilkan nilai variabel luasPersegiEmpat ke console.
        luasPersegiEmpat = persegiEmpatA.GetLuas()
        Console.WriteLine("Luas persegiEmpatA" & luasPersegiEmpat)

        luasPersegiEmpat = persegiEmpatB.GetLuas()
        Console.WriteLine("Luas persegiEmpatB" & luasPersegiEmpat)

        'Agar setelah console terbuka/tampil kemudian tidak langsung menutup.
        Console.ReadLine()
    End Sub
End Module
