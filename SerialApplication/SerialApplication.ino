#include <array>

void setup() {
  Serial.begin(115200);
  while (!Serial){}
}

std::array<byte ,124 > normalDistribution = { 227,
117,
100,
227,
118,
148,
187,
145,
140,
157,
214,
202,
164,
152,
121,
162,
111,
132,
171,
248,
200,
170,
138,
180,
154,
235,
129,
174,
113,
228,
190,
213,
156,
112,
122,
135,
211,
123,
122,
241,
125,
167,
253,
196,
234,
212,
185,
188,
142,
157,
137,
141,
142,
217,
167,
251,
224,
187,
251,
251,
241,
210,
123,
147,
111,
225,
162,
112,
121,
209,
125,
153,
182,
100,
104,
216,
155,
170,
117,
189,
185,
171,
211,
146,
230,
220,
177,
235,
253,
114,
240,
100,
150,
251,
162,
120,
214,
145,
178,
155,0,
5,
5,
0,
6,
7,
2,
5,
6,
7,
2,
2,
7,
3,
7,
9,
6,
6,
8,
6,
3,
1,
3,
0,
};

void loop() {

  for( auto && element :  normalDistribution)
    Serial.println(element);

    delay(100);
}
