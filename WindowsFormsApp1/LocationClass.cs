using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public struct LocationStruct
    {
        public float x, y;
        public int rssi;

        public LocationStruct(float _x, float _y) { x = _x; y = _y; rssi = -1; }

        public string LocationString() { return string.Format("({0},{1})", x, y); }
    }

    public struct BorderLine
    {
        public bool isReady;  // 計算結果はOKか？
        public bool isLine;   // true: 線, false: 円
        public float x, y;   // 円の中心、または、線上の点
        public float r;      // 円の半径（isLine==false）
        public float vx, vy; // 方向ベクトル（isLine==true）

        public BorderLine(LocationStruct p1, LocationStruct p2)
        {
            isLine = true;
            x = y = r = vx = vy = 0;

            isReady = p1.rssi > 0 && p2.rssi > 0;
            if (!isReady) return;
            float m, n;
            // 強度から距離の比を決める
            m = (float)1.0 / Math.Abs(p1.rssi);
            n = (float)1.0 / Math.Abs(p2.rssi);
            isLine = (p1.rssi == p2.rssi);
            if (isLine)
            {
                // 結果は直線
                x = (p1.x * n + p2.x * m) / (m + n);
                y = (p1.y * n + p2.y * m) / (m + n);
                vx = (p1.y - p2.y);
                vy = (p2.x - p1.x);
            }
            else
            {
                // 結果は円
                float m2 = m * m, n2 = n * n;
                x = (-p1.x * n2 + p2.x * m2) / (m2 - n2);
                y = (-p1.y * n2 + p2.y * m2) / (m2 - n2);
                float dist = (float)Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
                r = Math.Abs(m * n / (m2 - n2)) * dist;
            }
        }
    }
}
