Module ModuleMendefinisikanKelasBerisiKonstruktor
    'Contoh mendefinisikan kelas PersegiEmpat yang memiliki... 
    'dua atribut, dua konstruktor, dua prosedur dan satu fungsi.
    Class PersegiEmpat
        Private panjang As Integer
        Private lebar As Integer

        'Mendefinisikan constructor tanpa parameter.
        'Constructor akan dipanggil ketika inisialisasi/pembuatan objek.
        'Kode program di dalam constructor akan dijalankan ketika inisialisasi/pembuatan objek.
        'Constructor bersifat opsional (boleh didefinisikan, boleh tidak).
        'Jika tida perlu ada operasi lain yang dilakukan selain pembuatan objek dari kelas,...
        'constructor boleh tidak didefinisikan.
        'Apabila tidak didefinisikan, secara default constructor tidak memiliki parameter.
        Public Sub New()
            Console.WriteLine("Objek dari kelas PersegiEmpat sedang dibuat.")
        End Sub

        'Dalam satu kelas boleh mendefinisikan lebih dari satu constructor.
        'Namun constructor satu dan lainnya harus berbeda parameternya.
        'Mendefinisikan constructor dengan dua parameter, yaitu p dan lebar.
        'Ketika constructor dipanggil maka selain objek dari Kelas PersegiEmpat dibuat,...
        'variabel panjang akan diisi dengan argument yang dilewatkan melalui parameter p dan 
        'variabel lebar akan diisi dengan argument yang dilewatkan melalui parameter lebar. 
        Public Sub New(ByVal p As Integer, ByVal lebar As Integer)
            Console.WriteLine("Objek dari kelas PersegiEmpat sedang dibuat." + vbNewLine +
                              "Sekaligus dilakukan pengisian variabel panjang dan lebar.")
            panjang = p
            Me.lebar = lebar
        End Sub

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
        'Deklarasi dan inisialisasi objek persegiEmpatA dari kelas PersegiEmpat.
        'new PersegiEmpat() adalah proses inisialisasi (memanggil constructor tanpa parameter dari kelas PersegiEmpat).
        'Saat inisialisasi, kode program di dalam constructor akan dijalankan (dalam hal ini menampilkan teks...
        '"Objek dari kelas PersegiEmpat sedang dibuat" pada console).
        Dim persegiEmpatA As PersegiEmpat = New PersegiEmpat()

        'Mengisi nilai pada variabel panjang dan lebar dari objek persegiEmpatA...
        'dengan cara memanggil prosedur SetPanjang yang diisi argument bernilai 5... 
        'dan SetLebar yang diisi argument bernilai 3.
        persegiEmpatA.SetPanjang(5)
        persegiEmpatA.SetLebar(3)

        'Memanggil fungsi GetLuas dari objek persegiEmpatA untuk mendapatkan hasil perkalian...
        'dari nilai variabel panjang dan lebar
        'Langsung menampilkan hasil perkalian yang dihasilkan tanpa menyimpannya terlebih dahulu ke dalam variabel.
        Console.WriteLine("Luas persegiEmpatA = " & persegiEmpatA.GetLuas() & vbNewLine)

        'Deklarasi dan inisialisasi objek persegiEmpatB dari kelas PersegiEmpat.
        'Inisialisasi/pembuatan objek persegiEmpatB dilakukan dengan memanggil constructor dari kelas PersegiEmpat...
        'yang memiliki dua paramter untuk menerima dua argument dalam hal ini constructor...
        'Public Sub New(ByVal p As Integer, ByVal lebar As Integer).
        Dim persegiEmpatB As PersegiEmpat = New PersegiEmpat(7, 4)

        'Memanggil fungsi GetLuas dari objek persegiEmpatB untuk mendapatkan hasil perkalian...
        'dari nilai variabel panjang dan lebar
        'Langsung menampilkan hasil perkalian yang dihasilkan tanpa menyimpannya terlebih dahulu ke dalam variabel.
        Console.WriteLine("Luas persegiEmpatB = " & persegiEmpatB.GetLuas())

        Console.ReadLine()
    End Sub
End Module
