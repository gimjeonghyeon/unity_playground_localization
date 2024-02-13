# Localization

### 학습자료

https://youtu.be/VNhzMEsy7xc?t=942&si=ABLj3PNpgoFTm-S4

# Localization Settings

### Locale Selectors

- Command Line Locale Selector
    - 다국어 언어를 커맨드라인에서 바꿔주는 시스템을 사용시
- System Locale Selector
    - 시스템에서 설정된 기본 언어를 가져올 때
- Specific Locale Selector
    - 프로젝트에서 임의로 선택한 언어를 가져올 때

# 사용 언어 설정

1. Locale Generator 선택

![Untitled](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/0374c98d-b097-436c-90cb-e989884cb0a9)

1. 원하는 언어를 선택 후 Generate Locales 선택

![Untitled 1](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/c7b72ff4-7ee4-4bfb-9c94-3cac5e19f075)

2. 생성된 Locale 파일들 확인

![Untitled 2](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/a86018e4-112d-412c-b137-6c37d0181240)

3. Locale Selectors에서 Specific Locale Seletor 추가 후 생성된 Locale 연결

![Untitled 3](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/8a96398a-f23f-4366-9ccd-145d67d54f0f)

4. Project Locale Identifier 에서 프로젝트에서 사용할 기본 언어 선택

![Untitled 4](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/e07fa3a1-6993-48cd-a3f9-3b26bedc7413)


# 테이블 추가

### 1. Window > Asset Management > Localization Tables 실행

### 2. New Table Collection 탭에서 테이블 Type 및 Name 설정 후 Create

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/10ba9f10-17c0-4584-b78d-da2c668b21cd)

### 3. 생성된 테이블 확인

![Untitled 7](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/1e75f720-23a6-4e70-bb3f-c026bb441ee8)
![Untitled 6](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/a781635d-ad1c-4537-94b5-efc27e25ac4d)


- Playground Table
    - 생성된 테이블의 Collection
- Playgound Table_xx (en, ja, ko)
    - Collection에 포함되는 내용이 관리되는 파일

# 스트링 데이터 추가

### 1. Edit Table Collection에서 데이터를 추가할 테이블 선택
### 2. Add New Entry를 선택하여 데이터 추가
### 3. 추가된 데이터의 key와 언어에 맞는 값 입력

![Untitled 8](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/4cf3a2b7-e44f-4570-83ae-5d1f799ac9be)


### 4. Metadata
    a. Preload All Tables, Preload Table 을 선택하여 기본적으로 Table 을 로드할지를 선택
    b. 각 테이블 또는 항목에 대한 Comment를 추가 가능
    c. 플랫폼별 override 기능 제공

![Untitled 9](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/33be0aea-1f2a-4d2d-890f-2c6b53131453)


# 이벤트로 String 적용

### 1. Text 컴포넌트가 있는 게임오브젝트에 Localize String Event 컴포넌트 추가

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/c1ebc4a9-7c69-4426-b05d-8bb546783881)


### 2. Edit > Preferences > Localization 의 아래 설정 해제
(String Reference를 선택할 때 UI가 달라지는 것으로 보임)
- Asset Search Picker
- String Search Picker

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/9cef40f3-830c-4043-8233-474d9eb06b8b)

- 설정 해제 전
  
![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/646e4c43-9e09-40d8-a7ed-fd80709d6631)

- 설정 해제 후
  
![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/564c7acd-881d-481a-a5e6-34b32bc5f5f4)


### 3. Update String 설정

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/6e27df2d-b067-43fa-abcc-915cc9edee5d)

### 4. 이벤트 설정을 Editor And Runtime 으로 변경
- Editor And Runtime 설정시 플레이모드와 편집모드 모두에서 이벤트 동작을 확인하고 값을 업데이트 할 수 있음.

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/6753425c-f5dc-4288-bf24-95d40e0eb69e)


### 5. 플레이 모드에서 언어를 변경하여 Update String이 정상적으로 동작하는지 확인 가능

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/81bf2d95-8232-48c1-94d2-05ff29ab4cc2)



# Localize String Event 컴포넌트에서 테이블에 스트링 데이터 추가

### 1. 테이블을 선택후 Add Table Entry 를 선택

- Entry Name : 키 값

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/f700e36a-3aa6-4b25-a1fe-c72bcf9be1d6)
