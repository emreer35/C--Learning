using System;

namespace GenericsIntro;

public class MyList<T>
{
    // 1-- generic bir tip olusturduk ve simdi new ile yeni bir bellek olusturacagiz heap bellegine 
    // normalde bu sekilde items diye array olustururuduk fakat bizim class T tipinde oldugunda 
    // string[] items;
    // T tipli bir array olusturacagiz

    T[] items;
    // constructor olusturup icine referance adresi vermemiz gerekiyor ilk cagirildiginda class
    // items arrayi 0 elemanli olarak calissin
    public MyList()
    {
        items = new T[0];
    }
    public void Add(T item)
    {
        // fakat biz her add ekledigimizde yeni bir referance adresi olusturacak 
        // ve eski ekledigimiz veriler kaybolacak bu yuzden gecici olarak bizim eski verilerimizi 
        // tutacak bir gecici array olusturmamiz lazim
        T[] tempArray = items;
        items = new T[items.Length + 1];
        // temp array i items a eklememiz gerekiyor for dongusu ile icine ekleyecegiz
        for (int i = 0; i < tempArray.Length; i++)
        {
            //items in i.ci indexine tempArray in i.ci indexini kopyaliyoruz tekrardan
            items[i] = tempArray[i];
        }
        // ve simdi ise gelen veriyi items in icerisine eklememiz gerekiyor
        // neden items.length -1 yaptik 
        // cunku index degerine gore atayacagimizdan 5item 4. indexte tutulur gibi dusun 
        items[items.Length - 1] = item;

    }
}
