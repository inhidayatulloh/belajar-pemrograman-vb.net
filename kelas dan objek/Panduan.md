## Panduan Belajar Pemrograman VB.Net materi Kelas dan Objek menggunakan contoh kode program pada github ini.

### Deskripsi File
**1. ModuleMendefinisikanKelasBerisiAtribut.vb**
   Modul ini berisi materi pembelajaran untuk
   - mendefinisikan Kelas yang memiliki beberapa Atribut/Properti
   - membuat Objek (mendeklarasikan dan menginisialisasi Objek) dari Kelas yang telah didefinisikan
   - menggunakan atribut dari Objek untuk melakukan operasi

**Setelah berhasil menjalankan dan memahami kode program pada File 1, silahkan melakukan percobaan yaitu:**
Cut kode program yang digunakan untuk mendefinisikan Kelas dengan beberapa Atribut (mulai Class hingg End Class), kemudian Paste di bagian atas / luar dari definisi Module ModuleMendefinisikanKelasBerisiAtribut di dalam file yang sama, kemudian jalankan program! Apa yang terjadi? Jawabannya: **Meskipun Kelas berada di luar definisi Module namun tetap dapat diakses dari dalam Module**.

**2. ModuleProsedurFungsiDanEnkapsulasiPadaKelas.vb**
   Modul ini berisi materi pembelajaran untuk
   - mendefinisikan Kelas yang memiliki Atribut, Prosedur, dan Fungsi
   - membuat Objek (mendeklarasikan dan menginisialisasi Objek) dari Kelas yang telah didefinisikan
   - menerapkan Enkapsulasi (mendeklarasikan variabel dengan modifier Private dan mengaksesnya melalui prosedur/fungsi dengan modifier Public)
   - memanggil prosedur/fungsi dari Objek untuk melakukan operasi

**Setelah berhasil menjalankan dan memahami kode program pada File 2, silahkan melakukan percobaan yaitu:**
Pada bagian setelah deklarasi dan inisialisasi Objek persegiEmpatA dan persegiEmpatB, tambahkan kode program berikut:
```
persegiEmpatA.panjang = 5
persegiEmpatA.lebar = 3
persegiEmpatB.panjang = 4
persegiEmpatB.lebar = 4
```
Jalankan program! Apa yang terjadi?
Jawabannya: **terjadi error dikarenakan variabel panjang dan lebar tidak dapat diakses dari luar kelas secara langsung dikarenakan memiliki modifier Private**.

**3. ModuleMendefinisikanKelasBerisiKonstructor.vb**
   Modul ini berisi materi pembelajaran untuk
   - mendefinisikan Kelas yang memiliki beberapa Atribut, Konstruktor, Prosedur, dan Fungsi
   - membuat Objek (mendeklarasikan dan menginisialisasi Objek) dari Kelas yang telah didefinisikan
      - melalui konstruktor tanpa parameter
      - melalui konstruktor yang memiliki parameter
   - menggunakan prosedur/fungsi dari Objek untuk melakukan operasi

**4. ClassLingkaranDiLuarModule.vb**
   Modul ini berisi materi pembelajaran untuk
   - mendefinisikan Kelas di luar Module
   - mengkonversi Double ke String dengan format dua angka di belakang koma

**5. ModuleMengaksesKelasDiLuarModule.vb**
   Modul ini berisi materi pembelajaran untuk mengakses Kelas dari luar Module. 
   Kelas dan Module berada pada file .vb yang berbeda namun masih dalam satu projek yang sama.
