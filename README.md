# Localization

### 학습자료

https://youtu.be/VNhzMEsy7xc?si=OIAkCC3lYkk9HLii&t=1351

# Localization Settings

### Locale Selectors

- Command Line Locale Selector
    - 다국어 언어를 커맨드라인에서 바꿔주는 시스템을 사용시
- System Locale Selector
    - 시스템에서 설정된 기본 언어를 가져올 때
- Specific Locale Selector
    - 프로젝트에서 임의로 선택한 언어를 가져올 때

# 사용 언어 설정

### 1. Locale Generator 선택

![Untitled](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/0374c98d-b097-436c-90cb-e989884cb0a9)

### 1. 원하는 언어를 선택 후 Generate Locales 선택

![Untitled 1](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/c7b72ff4-7ee4-4bfb-9c94-3cac5e19f075)

### 2. 생성된 Locale 파일들 확인

![Untitled 2](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/a86018e4-112d-412c-b137-6c37d0181240)

### 3. Locale Selectors에서 Specific Locale Seletor 추가 후 생성된 Locale 연결

![Untitled 3](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/8a96398a-f23f-4366-9ccd-145d67d54f0f)

### 4. Project Locale Identifier 에서 프로젝트에서 사용할 기본 언어 선택

![Untitled 4](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/e07fa3a1-6993-48cd-a3f9-3b26bedc7413)


# 테이블 추가

### 1. Window > Asset Management > Localization Tables 실행

### 2. New Table Collection 탭에서 테이블 Type 및 Name 설정 후 Create

![ddd](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/f615b13f-758c-42c0-ae3a-40da4bf6c28a)

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


# 이벤트를 통한 String 적용

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

- Window > Asset Management > Localization Scene Controls 에서 Active Locale을 변경하여 Editor에서 동작 확인 가

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/b9292bd6-0ac2-41e9-893b-e7fee72c7004)


### 5. 플레이 모드에서 언어를 변경하여 Update String이 정상적으로 동작하는지 확인 가능

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/81bf2d95-8232-48c1-94d2-05ff29ab4cc2)



# Localize String Event 컴포넌트에서 테이블에 스트링 데이터 추가

### 1. 테이블을 선택후 Add Table Entry 를 선택

- Entry Name : 키 값

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/f700e36a-3aa6-4b25-a1fe-c72bcf9be1d6)

# 이벤트를 통한 Asset 적용

### 1. Asset Table 생성

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/a6570bc1-8a43-42f8-9477-785e5a43c4b6)

### 2. 데이터 추가
- Key값 설정 후 2D Texture가 아닌 Sprite로 에셋 데이터 추가

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/e14e16f6-e5e3-46f0-a5bb-03d68ced3f20)

### 3. 이벤트 추가
- 컴포넌트의 (...) 버튼 클릭후 Localize를 선택하는 방법으로 이벤트 추가 가능 (Localize Sprite Event 컴포넌트가 추가 됨)

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/8e5cc66b-f23d-4c34-bdba-8ff460c3a42d)

- 해당 방식으로 이벤트가 추가된 경우 Update Asset 이벤트가 기본으로 설정 되어 있음

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/310a6921-6d1e-41ff-899e-4c20b86eaeee)

### 4. Localized Asset Reference 설정
- 추가해준 Asset Table의 Key값으로 설정

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/a83020fd-b18c-43c6-95f4-603ce628f7e0)

### 5. 플레이 모드로 진입하여 언어 선택에 따라 Sprite가 변경되는 것 확인

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/d3c59e08-9669-41f7-b5a1-751897fcff2c)


# 선택된 언어에 따라 레이아웃 변경

### 1. Localization Scene Controls 의 Track Changes 화성화

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/493080b0-58de-4e8d-9c5f-14ef2563537a)

### 2. 레이아웃 변경이 필요한 게임오브젝트 위치 변경

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/963be706-0053-4e22-be6a-b7cb0f039508)


### 3. 변경이 발생한 내용 확인

- 변경이 발생한 속성은 초록색으로 표시 됨

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/5d434f1b-7f70-497e-824c-d81d5a19dad3)

- 변경이 발생하는 경우 Game Object Localizer 컴포넌트가 게임오브젝트에 자동으로 추가되며, Tacked Objects에서 언어별 설정된 상세 내용 확인 가능

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/6f481bc6-d678-4c23-9ecb-f5a82c40c3fa)

### 4. 작업이 완료된 이후 Track Changes 비활성화

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/f17e12c6-ec33-403d-bb1a-f40594ee1175)


# Smart 기능을 활용하여 별도의 데이터 처리

### 1. Variables Group Asset 생성

- 마우스 우클릭 > Create > Localization > Variable Group 선택

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/a3bf9d2a-68e2-4a5c-b507-f008355e7273)

### 2. Variables에 필요한 데이터 추가

- 추가할 데이터 형식 선택 후 아래의 값 입력
    -- Variable Name : 참조시 사용할 이름
    -- String : 실제 데이터

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/36e52f3d-fa4e-4326-94a2-2d0f2f98d78d)

### 3. String Table에 Smart 기능을 사용할 Entry 추가

- 출력해줄 Text 컴포넌트가 있는 게임오브젝트에 Localize String Event 추가 > 테이블 선택 > Add Table Entry 선택 > Entry Name 입력

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/349c7797-3815-4da4-a020-d3ba3983a543)

### 4. Local Variables 를 추가

- +버튼을 누른 뒤 Nested Variables Group 선택
  -- Variable Name : Variables Group 참조시 사용할 이름 입력
  -- Nested Variable Group : 생성해주었던 Variables Group Asset 선택

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/eedec3c6-aa04-4048-8546-92f5d815743d)

### 4. Smart 기능 활성화 후 데이터 입력

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/21c76ca6-6ece-49e1-ae17-6e795adf67a6)

- 데이터 입력은 중괄호 안에 Variable Group Name.Variable Name 으로 입력
  -- 예시: {global.user-name}
- Edit : 데이터를 입력하는 곳
- Debug : 디버깅 가능? (단순히 Variable 데이터가 주황색으로 표시되어지는 것 같음, 틀리게 작성해도 별다른 확인이 되진 암ㅎ음)
- Preview : 실제 플레이 모드에서 보여질 형태로 출력 (Variable 데이터가 잘못 입력된 경우 Preview 출력을 통 확인 가능)

Variable이 제대로 입력되지 않은 경우 출력은 다음과 같음.

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/d61f566e-1cc6-4164-a23d-2df78a58c0fe)

### 5. 언어가 변경되어도 동일하게 출력되는 Variable 데이터 확인

![image](https://github.com/gimjeonghyeon/unity_playground_localization/assets/17286534/6c65f7bf-ba8a-4b4b-a5f4-de96fd120d7b)

