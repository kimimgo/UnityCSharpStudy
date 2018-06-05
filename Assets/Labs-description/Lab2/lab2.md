# Lab2 : Unity에서 데이터 베이스 다루기

C#에서 텍스트 파일을 처리하는데는 File 클래스의 간단한 유틸러티 메서드들이 쉽고 간편하다.
여기서는 StreamReader, StreamWriter 클래스를 사용하여 보다 낮은 레벨의 파일 처리를 다뤄보자.
Stream 시리즈의 클래스는 택스트를 line 단위로 처리하기 때문에 장점이 많다.
예컨데 100x100 크기의 메트릭스가 총 100개 저장이 되어 있고, 1초에 1개씩 가시화 해야한다고 해보자. 
단순하게 File 클래스를 사용한다고 생각한다면 총 100만개의 데이터를 한꺼번에 메모리에 저장하여 가시화 해야할 수도 있는 것이다.
StreamReader를 사용한다면 (저장되어 있는 데이터 형태에 따라 다르겠지만) 한번에 메모리에 저장되는 데이터 사이즈를 적절하게 컨트롤이 가능하다.
(Big-O 스케일로 공간 복잡도가 줄어듦, 더 나아가 시간 복잡도 까지 고려하기 수월하게 됨.)

# Json / XML ?
데이터를 저장하는 형태에 따라 SQL Json XML 등의 표준 포멧이 존재한다.
최근 IT업계 경향을 살펴보면 Json을 많이 사용하는 추세이다.
http://usbs.tistory.com/entry/XML-JSON-%EA%B0%84%EB%8B%A8%ED%95%9C-%EB%B9%84%EA%B5%90-%EB%B6%84%EC%84%9D
http://prohannah.tistory.com/16
장단점이 존재하는데 iCAD 연구실의 경우 TransCAD와 매크로 파라메트릭스의 기술 개발이 주로 XML로 이루어졌다.


## 수행내용
data.txt파일은 학생당 과목별 점수임. 이 입력 파일을 읽어들여 각 학생별 성적의 합계와 평균을 구하여 출력 파일에 쓰는 프로그램을 작성하기.
1. 입력 데이타파일(data.txt)은 아래 그림과 같이 각 컬럼이 콤마로 분리되어 있습니다. (input.bmp)
2. 출력파일은 아래 그림과 같이 ID, 국어, 영어, 수학, 합계, 평균 등 6개의 컬럼으로 되어 있으며, 각 컬럼이 콤마로 분리되도록 작성하기. (output.bmp)
3. C# 프로그램 작성시 Text 파일을 처리하는 StreamReader, StreamWriter 클래스를 사용해서 구현하기
4. (optional) output 파일을 xml 파일로 구조화 하여 저장해보기 
예)
"<student>
    <number>1</number>
    <korean>85</korean>
    <english>92</english>
    <math>88</math>
    <sum> ... </sum>
    <avrg> ... </avrg>
</student>
..."

힌트 : system.xml 클래스의 XmlDocument 이용하기.

## 추가 공부 : 유니티에서 JSON 사용하기
JSON 데이터를 읽기위헤서는 Parser가 필요함. 굉장히 많은 Parser가 많음. .NET 표준도 있고 웹표준도 있고 크롬에서 사용하는 라이브러리도 있음.
LitJSON이 편하다고해서 한번 사용해봄
https://github.com/LitJSON/litjson



## 참고문헌
http://ronniej.sfuh.tk/%EC%9C%A0%EB%8B%88%ED%8B%B0%EC%97%90%EC%84%9C-json-%EC%82%AC%EC%9A%A9%ED%95%98%EA%B8%B0-1/
