# Tc-Kimlik-Numarasi-Maskeleme

C# Form Uygulaması ile TC Kimlik Numarasının Belirli Bölümlerini Maskelemeye Yarayan Program

Textbox üzerine girmiş olduğunuz 11 haneli değerin ilk üç hanesi ve son üç hanesi dışında kalanları "X" ile göstererek gizlemektedir. 
Bu kod fonksiyon ile tutulmaktadır. Bu sayede fonksiyon tanımlaması ile dıişarıya karşı TC Kimlik numarasını maskeleyerek yayınlayabilmekteyiz.

Visual Studio 2022

.NET Framework 4.8 (Minimum 4.0) & .NET Core 3.1 & 

<h2>Uygulama Kullanım Resimleri</h2>



  ![tc maskele](https://user-images.githubusercontent.com/76941464/165316892-bbf79726-1f3f-4eb4-9add-66c314b8b2bf.png)

![tc maskele 2](https://user-images.githubusercontent.com/76941464/165316904-4b07dcfd-d7d0-47d2-89c2-c0b2946d8f3a.png)


<h2>Function Kodu</h2>

<pre>
var tc = txtTc.Text;
var ilk = tc.Substring(0, 3);
var son = tc.Substring(tc.Length - 3, 3);
var mask = new string('X', tc.Length - ilk.Length - son.Length);
var maskelenmis = string.Concat(ilk, mask, son);
lblMaskelenmis.Text = maskelenmis.ToString();
</pre>
