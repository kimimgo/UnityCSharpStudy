#Lab4 Unity Shader Programming

Unity에서는 OpenGL과 같은 Low-level의 그래픽스 라이브러리 보다 더 쉽게 셰이더를 구현할 수 있다.
더불어 Global Illumination과 같은 계산량이 높다고 알려져있던 Physical based rendering 기능도 Unity5부터 제공하기 시작하였다.
특히 Unity의 컴퓨트 셰이더(Compute Shader)란 특수한 기능이 있는데 이는  GPU를 사용하여 간단한 처리를 병렬화 하고 많은 양의 작업을 고속으로 실행하기 위해 이용된다.
또한 같은 GPU를 이용한 처리를 하지만 일반적인 렌더링 파이프라인과 다른 특징이 있다.
CG에서는 종종 많은 수의 입자의 움직임을 표현하는 데 사용된다.

Unity 컴퓨트 셰이더의 기본 개념은 DirectX의 DirectCompute와 밀접한 관련이 있으며, 
이밖에도 OpenCL, CUDA 등의 유사한 기술들이 존재한다. 
이러한 GPGPU (General-Purpose GPU, 범용 GPU 계산) 아키텍처에 대한 자세한 연구는 전산학에서 굉장히 역사가 오래된 분야이다.
(intel의 무어의 법칙이 깨짐으로 인해 cpu 병렬화에 투자하기 시작한지 꽤되었음.)

## 수행내용

구상중 ㅎㅎ