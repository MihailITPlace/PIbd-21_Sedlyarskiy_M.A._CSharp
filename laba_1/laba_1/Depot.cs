using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    class Depot<T> : IEnumerator<T>, IEnumerable<T>, IComparable<Depot<T>> where T : class, ITransport
    {
        private Dictionary<int, T> _places;

        private int _maxCount;

        private int _currentIndex;

        private int PictureWidth { get; set; }

        private int PictureHeight { get; set; }

        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        private int _placeSizeWidth = 210;

        private int _placeSizeHeight = 80;

        public Depot(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            _currentIndex = -1;
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }

        public static int operator +(Depot<T> p, T locomotive)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new DepotOverflowException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, locomotive);
                    p._places[i].SetPosition(5 + i / 5 * p._placeSizeWidth + 5, i % 5 * p._placeSizeHeight + 15, p.PictureWidth, p.PictureHeight);
                    return i;
                }
                else if (locomotive.GetType() == p._places[i].GetType())
                {
                    if (locomotive is Monorail)
                    {
                        if ((locomotive as Monorail).Equals(p._places[i]))
                        {
                            throw new DepotAlreadyHaveException();
                        }
                    }
                    else if ((locomotive as ElectricLocomotive).Equals(p._places[i]))
                    {
                        throw new DepotAlreadyHaveException();
                    }
                }
            }
            return -1;
        }

        public static T operator -(Depot<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T car = p._places[index];
                p._places.Remove(index);
                return car;
            }

            throw new DepotNotFoundException(index);
        }

        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].Draw(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                    i * _placeSizeWidth + 110, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }

        public void Dispose()
        {
            _places.Clear();
        }

        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(Depot<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is ElectricLocomotive && other._places[thisKeys[i]] is Monorail)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is Monorail && other._places[thisKeys[i]] is ElectricLocomotive)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is ElectricLocomotive && other._places[thisKeys[i]] is ElectricLocomotive)
                    {
                        return (_places[thisKeys[i]] is ElectricLocomotive).CompareTo(other._places[thisKeys[i]] is ElectricLocomotive);
                    }
                    if (_places[thisKeys[i]] is Monorail && other._places[thisKeys[i]] is Monorail)
                    {
                        return (_places[thisKeys[i]] is Monorail).CompareTo(other._places[thisKeys[i]] is Monorail);
                    }
                }
            }
            return 0;
        }

        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new DepotNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5 * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new DepotOccupiedPlaceException(ind);
                }
            }
        }
    }
}
