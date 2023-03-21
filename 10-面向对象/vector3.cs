using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_面向对象
{
    internal class vector3
    {
        //类数据一般为private，不可直接访问
        private float x = 0;
        private float y = 0;
        private float z = 0;

        //提供方法去修改数据
        public void SetX(float x)
        {
            //可判断给出的数据是否符合要求，是则可修改数据
            if (x < 0)return;
            this.x = x; 
        }
        public void SetY(float y) { this.y = y; }
        public void SetZ(float z) {  this.z = z; }

        //获得向量值
        public float GetX() { return x; }
        public float GetY() { return y; }
        public float GetZ() { return z; }

        //输出向量长度
        public float Length()
        {
            return MathF.Sqrt(x * x + y * y + z * z);
        }
    }
}
