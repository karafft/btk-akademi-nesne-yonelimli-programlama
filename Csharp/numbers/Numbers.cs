namespace numbers;
public class Numbers
{
    public int[] _arr; //Global Scope
    public int _counter; //Global Scope

    public Numbers(int size)
    {
        _arr = new int[size];
        _counter = 0;
    }

    public void Add(int value)
    {
        if (_counter >= _arr.Length)
        {
            throw new Exception("Dizi kapasitesi dolu!");
        }

        _arr[_counter] = value;
        _counter++;
    }
    
    public int GetValue(int index)
    {
        // Out of range hatasını önlemek için index >= _counter olarak düzeltildi.
        if (index < 0 || index >= _counter)
        {
            throw new IndexOutOfRangeException("Dizi indexi geçersiz.");
        }
        return _arr[index];
    }

    public int FindMax()
    {
        if (_arr == null || _counter == 0)
        {
            throw new Exception("Dizi boş veya tanımlanmamış.");
        }

        int max = _arr[0];
        for (int i = 1; i < _counter; i++)
        {
            if (_arr[i] > max)
            {
                max = _arr[i];
            }
        }
        return max;
    }
    
    public int FindMin()
    {
        if (_arr == null || _counter == 0)
        {
            throw new Exception("Dizi boş veya tanımlanmamış.");
        }

        int min = _arr[0];
        for (int i = 1; i < _counter; i++)
        {
            if (_arr[i] < min)
            {
                min = _arr[i];
            }
        }
        return min;
    }

    // Ödev verilen sayının indexini bulan method (Program.cs'den buraya taşındı)
    public int FindIndex(int value)
    {
        for (int i = 0; i < _counter; i++)
        {
            if (_arr[i] == value)
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
        if (_counter > 0)
        {
            _counter--;
        }
        else
        {
            Console.WriteLine("Hata: Dizi zaten boş. 0'dan aşağı düşemez.");
        }
    }
    
    // (Ekstra) İsteğe bağlı olarak index ile silme işlemi yapan RemoveAt metodu:
    public void RemoveAt(int index)
    {
        // Out of range hatası önleme
        if (index < 0 || index >= _counter)
        {
            Console.WriteLine("Hata: Geçersiz index. Out of range önlendi.");
            return;
        }

        for (int i = index; i < _counter - 1; i++)
        {
            _arr[i] = _arr[i + 1];
        }
        _counter--;
    }
}
