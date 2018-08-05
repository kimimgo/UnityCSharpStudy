#Lab2 파일 I/O txt와 xml
이번 Lab에서는 C#으로 텍스트 파일을 처리하는 부분에 대해 실습해 보자.
C#에서 텍스트 파일을 처리하는데는 File 클래스의 간단한 유틸러티 메서드들이 쉽고 간편하지만, 
여기서는 StreamReader, StreamWriter 클래스를 사용하여 보다 낮은 레벨의 파일 처리를 다뤄보자.

## 수행내용
data.txt파일은 학생당 과목별 점수임. 이 입력 파일을 읽어들여 각 학생별 성적의 합계와 평균을 구하여 출력 파일에 쓰는 프로그램을 작성하기.
1. 입력 데이타파일(data.txt)은 아래 그림과 같이 각 컬럼이 콤마로 분리되어 있습니다. (input.bmp)
2. 출력파일은 아래 그림과 같이 ID, 국어, 영어, 수학, 합계, 평균 등 6개의 컬럼으로 되어 있으며, 각 컬럼이 콤마로 분리되도록 작성하기. (output.bmp)
3. C# 프로그램 작성시 Text 파일을 처리하는 StreamReader, StreamWriter 클래스를 사용해서 구현하기
4. (optional) output 파일을 xml 파일로 구조화 하여 저장해보기 
예)
<student>
    <number>1</number>
    <korean>85</korean>
    <english>92</english>
    <math>88</math>
    <sum> ... </sum>
    <avrg> ... </avrg>
</student>
...

힌트 : system.xml 클래스의 XmlDocument 이용하기.