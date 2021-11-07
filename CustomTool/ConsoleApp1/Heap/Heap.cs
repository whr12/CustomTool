using System.Collections.Generic;

namespace Tool.ExternContainer
{

    public abstract class Heap<T>
    {
        private List<T> m_datas;
        private int m_count;

        public int Count => m_count;

        public Heap()
        {
            m_datas = new List<T>();
        }

        public void Push(T data)
        {
            m_datas.Add(data);
            m_datas[m_count] = data;
            PercolateUp(m_count);
            ++m_count;
        }

        public void Pop()
        {
            if (m_count > 1)
            {
                --m_count;
                m_datas[0] = m_datas[m_count];
                m_datas.RemoveAt(m_count);
                PercolateDown(0);
            }
            else
            {
                if (m_count > 0)
                {
                    m_datas.RemoveAt(0);
                    --m_count;
                }
            }
        }

        public T GetHeap()
        {
            if (m_count <= 0)
            {
                throw new System.Exception("It is empty in the heap");
            }
            return m_datas[0];
        }

        public void Clear()
        {
            m_datas.Clear();
            m_count = 0;
        }

        protected void PercolateUp(int index)
        {
            T value = m_datas[index];
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;
                if (Compare(value, m_datas[parentIndex]) < 0)
                {
                    m_datas[index] = m_datas[parentIndex];
                    index = parentIndex;
                }
                else
                {
                    break;
                }
            }
            m_datas[index] = value;
        }

        protected void PercolateDown(int index)
        {
            T value = m_datas[index];
            while (index < m_count)
            {
                int childL = 2 * index + 1;
                int childR = childL + 1;
                int maxChild = index;

                if (childL < m_count)
                {
                    if (Compare(m_datas[index], m_datas[childL]) > 0)
                    {
                        m_datas[index] = m_datas[childL];
                        maxChild = childL;
                    }
                }
                if (childR < m_count)
                {
                    if (Compare(m_datas[index], m_datas[childR]) > 0)
                    {
                        m_datas[index] = m_datas[childR];
                        maxChild = childR;
                    }
                }
                if (maxChild == index)
                {
                    break;
                }
                index = maxChild;
            }
            m_datas[index] = value;
        }

        protected abstract int Compare(T l, T R);
    }
}