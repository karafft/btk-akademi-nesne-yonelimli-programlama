namespace numbers;
public class Numbers
{
    public int[] arr; //Global Scope
    public int counter; //Global Scope

    public Numbers(int size)
    {
        this.arr = new int[size];
        this.counter = 0;
    }

    public void Add(int value)
    {
        if (this.counter >= this.arr.Length)
        {
            throw new Exception("Dizi kapasitesi dolu!");
        }

        this.arr[this.counter] = value;
        this.counter++;
    }

    public int GetValue(int index)
    {
        // Out of range hatasını önlemek için index >= counter olarak düzeltildi.
        if (index < 0 || index >= this.counter)
        {
            throw new IndexOutOfRangeException("Dizi indexi geçersiz.");
        }
        return this.arr[index];
    }

    public int FindMax()
    {
        if (this.arr == null || this.counter == 0)
        {
            throw new Exception("Dizi boş veya tanımlanmamış.");
        }

        int max = this.arr[0];
        for (int i = 1; i < this.counter; i++)
        {
            if (this.arr[i] > max)
            {
                max = this.arr[i];
            }
        }
        return max;
    }

    public int FindMin()
    {
        if (this.arr == null || this.counter == 0)
        {
            throw new Exception("Dizi boş veya tanımlanmamış.");
        }

        int min = this.arr[0];
        for (int i = 1; i < this.counter; i++)
        {
            if (this.arr[i] < min)
            {
                min = this.arr[i];
            }
        }
        return min;
    }

    // Ödev verilen sayının indexini bulan method 
    public int FindIndex(int value)
    {
        for (int i = 0; i < this.counter; i++)
        {
            if (this.arr[i] == value)
            {
                return i;
            }
        }
        return -1;
    }

    // Ödev remove methodu
    public void Remove()
    {
        // out of range hatası önleme. 0 dan aşağı düşmemesini sağla.
        if (this.counter > 0)
        {
            this.counter--;
        }
        else
        {
            Console.WriteLine("Hata: Dizi zaten boş. 0'dan aşağı düşemez.");
        }
    }

    // index ile silme işlemi yapan RemoveAt metodu:
    public void RemoveAt(int index)
    {
        // Out of range hatası önleme
        if (index < 0 || index >= this.counter)
        {
            Console.WriteLine("Hata: Geçersiz index. Out of range.");
            return;
        }

        for (int i = index; i < this.counter - 1; i++)
        {
            this.arr[i] = this.arr[i + 1];
        }
        this.counter--;
    }
}
