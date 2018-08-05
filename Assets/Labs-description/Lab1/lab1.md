# Lab1 : debug 콘솔창 Unity 인게임에서 띄우기

기본적으로 Unity에서는 디버그 콘솔 인터페이스를 제공한다.
단축키 : Ctrl+Shift+Console
https://docs.unity3d.com/kr/2018.1/Manual/Console.html

그러나 여러가지 상황에 인게임 디버그창이 필요한 경우가 많다.
(예 : 배포버전으로 에러 여부를 판단해보고 싶을때, 로그 파일 확인하기가 귀찮을때 등)
***
http://matthewminer.com/
여러 편리성이 있으므로 누군가 Unity 내부적으로 작동하는 콘솔 디버그 메시지를 Catch 해주는 함수를 잘 만들어 놓았는데, 이를 한번 활용 해보도록 한다.


## 수행내용
1. Console.cs 를 이용하여 Game 창에 디버그창 띄우기
2. 디버그창 띄우는 단축키를 알아내고, F5 으로 바꾸기.
3. 디버그창에 아래 문제를 풀어 함수로 작성하여 출력하기. (옵션)

### 문제
정수(int)가 주어지면, 팰린드롬(palindrome)인지 알아내기.
팰린드롬이란, 앞에서부터 읽으나 뒤에서부터 읽으나 같은 단어를 말함. 
단, 정수를 문자열로 바꾸면 안된다.
예)
Input: 12345
Output: False

Input: -101
Output: False

Input: 11111
Output: True

Input: 12421
Output: True
