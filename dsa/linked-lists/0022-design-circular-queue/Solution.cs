public class MyCircularQueue
{
    private readonly int[] _a;
    private int _head;
    private int _count;

    public MyCircularQueue(int k)
    {
        _a = new int[k];
        _head = 0;
        _count = 0;
    }

    public bool EnQueue(int value)
    {
        if (IsFull()) return false;
        int idx = (_head + _count) % _a.Length;
        _a[idx] = value;
        _count++;
        return true;
    }

    public bool DeQueue()
    {
        if (IsEmpty()) return false;
        _head = (_head + 1) % _a.Length;
        _count--;
        return true;
    }

    public int Front()
    {
        return IsEmpty() ? -1 : _a[_head];
    }

    public int Rear()
    {
        if (IsEmpty()) return -1;
        int idx = (_head + _count - 1) % _a.Length;
        return _a[idx];
    }

    public bool IsEmpty() => _count == 0;

    public bool IsFull() => _count == _a.Length;
}
