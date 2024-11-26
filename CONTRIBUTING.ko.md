<div align="center">
  <!-- 배너 -->
  <h1>🔧 BlockFlow Engine 기여 가이드</h1>
  <p>
    <a href="http://makeapullrequest.com">
      <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square" alt="PRs Welcome"/>
    </a>
    <a href="https://github.com/BlockFlow/Engine/graphs/contributors">
      <img src="https://img.shields.io/github/contributors/BlockFlow/Engine.svg?style=flat-square" alt="Contributors"/>
    </a>
    <a href="https://join.slack.com/t/pulsewavestudios/shared_invite/zt-2v3951tau-yC3V494lZKfkN8x0MxZuvg">
      <img src="https://img.shields.io/badge/Join-Slack-blue.svg?style=flat-square&logo=slack" alt="Slack"/>
    </a>
  </p>
  <p>🌏 <a href="./CONTRIBUTING.en.md">English</a> | 🌏 <a href="#-시작하기">한국어</a></p>
</div>

<hr>

<p align="center">
  🎉 **BlockFlow Engine**에 기여해주셔서 감사합니다! 여러분의 기여가 이 프로젝트를 더욱 빛나게 만듭니다.
</p>

<hr>

## 📚 목차
<ul>
  <li><a href="#-시작하기">🚀 시작하기</a></li>
  <li><a href="#-개발-워크플로우">💻 개발 워크플로우</a></li>
  <li><a href="#-코드-스타일-가이드라인">📝 코드 스타일 가이드라인</a></li>
  <li><a href="#-변경사항-제출">📮 변경사항 제출</a></li>
  <li><a href="#-커뮤니티-가이드라인">🤝 커뮤니티 가이드라인</a></li>
  <li><a href="#-도움받기">❓ 도움받기</a></li>
</ul>

<hr>

## 🚀 시작하기

### 1️⃣ 저장소 포크하기
**프로젝트의 개인 복사본 만들기**

1. GitHub에서 상단의 **"Fork"** 버튼을 클릭합니다.
2. GitHub 계정을 선택하여 포크를 생성합니다.
3. 포크가 완료되면, 로컬에서 작업을 시작할 준비가 되었습니다.

### 2️⃣ 포크 클론하기

- 저장소를 클론하려면:  
  <code>git clone https://github.com/your-username/BlockFlow-Engine.git</code>
  
- 로컬 디렉토리로 이동:  
  <code>cd BlockFlow-Engine</code>

### 3️⃣ 개발 환경 설정

- **유니티 프로젝트 열기**  
  Unity Hub에서 **BlockFlow-Engine** 프로젝트를 열어주세요.
  
- **필요한 패키지 설치**  
  Unity Package Manager를 사용해 필요한 모든 패키지를 설치합니다.
  
- **서버 및 Photon 설정**  
  프로젝트 설정 파일(backend.json, photon.json)을 열어 서버와의 연결을 설정합니다.

<hr>

## 💻 개발 워크플로우

### 1️⃣ 새 브랜치 생성
- **새 기능 추가**:  
  <code>git checkout -b feature/기능-이름</code>
  
- **버그 수정**:  
  <code>git checkout -b fix/버그-이름</code>

### 2️⃣ 변경사항 작업
- **깔끔한 코드**: 코드는 가독성이 높고 유지보수가 용이해야 합니다.
- **문서화**: 변경 사항에 맞게 문서를 업데이트해 주세요.
- **테스트 추가**: 새로운 기능에 대한 테스트 코드를 작성합니다.
- **주석 추가**: 복잡한 코드에는 설명을 달아 이해하기 쉽게 만들어주세요.

<hr>

## 📝 코드 스타일 가이드라인

- **들여쓰기는 2칸 공백 사용**
- **기존 코드의 스타일을 따르기**
- **의미 있는 이름 사용**
- **복잡한 로직에는 주석 추가**
- **함수는 하나의 역할에 집중**
- **단위 테스트 작성**

<hr>

## 📮 변경사항 제출

### 1️⃣ 변경사항 커밋
- 변경사항 스테이징:  
  <code>git add .</code>
  
- 커밋 메시지 작성:  
  <code>git commit -m "feat: 멋진 새 기능 추가"</code> 또는  
  <code>git commit -m "fix: 중요 버그 수정"</code>

### 2️⃣ 포크에 푸시
- <code>git push origin feature/기능-이름</code>

### 3️⃣ 풀 리퀘스트 생성

**풀 리퀘스트 체크리스트**  
다음 항목들을 확인해주세요:

- [ ] 코드가 스타일 가이드라인을 따릅니다.
- [ ] 모든 테스트가 통과합니다.
- [ ] 문서가 업데이트되었습니다.
- [ ] 풀 리퀘스트 설명이 명확합니다.
- [ ] 관련된 이슈와 연결됩니다.

<hr>

## 🤝 커뮤니티 가이드라인

- **서로를 존중하며 협력하세요!**
- **다른 사람의 학습과 성장을 돕고 배려해주세요.**
- **행동 강령을 준수하세요.**
- **건설적인 피드백을 제공하세요.**
- **적절한 크레딧을 부여하세요.**

<hr>

## ❓ 도움받기

도움이 필요하신가요? 언제든지 문의해주세요!

- [이슈 등록하기](https://github.com/BlockFlow/Engine/issues/new)
- [슬랙 참여하기](https://join.slack.com/t/pulsewavestudios/shared_invite/zt-2v3951tau-yC3V494lZKfkN8x0MxZuvg)

<hr>
