<div align="center">

# 🔧 BlockFlow Engine 기여 가이드

[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)](http://makeapullrequest.com)
[![Contributors](https://img.shields.io/github/contributors/BlockFlow/Engine.svg?style=flat-square)](https://github.com/BlockFlow/Engine/graphs/contributors)
[![Slack](https://img.shields.io/badge/Join-Slack-blue.svg?style=flat-square&logo=slack)](https://join.slack.com/t/pulsewavestudios/shared_invite/zt-2v3951tau-yC3V494lZKfkN8x0MxZuvg)

[🌏 English](./CONTRIBUTING.en.md) | [🌏 한국어](#-시작하기)

</div>

> 🎉 BlockFlow Engine에 기여해주셔서 감사합니다! 모든 기여는 이 프로젝트를 더 좋게 만드는 데 도움이 됩니다.

## 📚 목차

- [🚀 시작하기](#-시작하기)
- [💻 개발 워크플로우](#-개발-워크플로우)
- [📝 코드 스타일 가이드라인](#-코드-스타일-가이드라인)
- [📮 변경사항 제출](#-변경사항-제출)
- [🤝 커뮤니티 가이드라인](#-커뮤니티-가이드라인)
- [❓ 도움받기](#-도움받기)

## 🚀 시작하기

### 1️⃣ 저장소 포크하기
> 프로젝트의 개인 복사본 만들기

<details>
<summary>포크 생성 단계</summary>

1. 저장소 상단의 "Fork" 버튼 클릭
2. GitHub 계정 선택
3. 포크 생성 완료 대기

</details>

### 2️⃣ 포크 클론하기
```bash
# 저장소 클론
git clone https://github.com/your-username/BlockFlow-Engine.git

# 디렉토리로 이동
cd BlockFlow-Engine
```

### 3️⃣ 개발 환경 설정
```bash
# 의존성 설치
npm install

# pre-commit 훅 설정
npm run prepare
```

## 💻 개발 워크플로우

### 1️⃣ 새 브랜치 생성
```bash
# 새로운 기능 개발 시
git checkout -b feature/기능-이름

# 버그 수정 시
git checkout -b fix/수정-이름
```

### 2️⃣ 변경사항 작업
| 📝 할 일 | ℹ️ 설명 |
|----------|---------|
| 깔끔한 코드 | 유지보수가 쉽고 읽기 좋은 코드 작성 |
| 문서화 | 관련 문서 업데이트 |
| 테스트 | 새로운 기능에 대한 테스트 추가 |
| 주석 | 복잡한 로직에 대한 설명 추가 |

### 3️⃣ 변경사항 테스트
```bash
# 테스트 스위트 실행
npm run test

# 코드 스타일 검사
npm run lint
```

## 📝 코드 스타일 가이드라인

> 일관성 유지를 위해 엄격한 코딩 표준을 따릅니다

- ⚡ 들여쓰기는 2칸 공백 사용
- 📏 기존 코드 패턴 따르기
- 🏷️ 의미 있는 이름 사용
- 💭 복잡한 로직에 주석 추가
- 🎯 함수는 한 가지 역할에 집중
- ✅ 단위 테스트 작성

## 📮 변경사항 제출

### 1️⃣ 변경사항 커밋
```bash
# 변경사항 스테이징
git add .

# 설명적인 메시지로 커밋
git commit -m "feat: 멋진 새 기능 추가"
# 또는
git commit -m "fix: 중요 버그 수정"
```

### 2️⃣ 포크에 푸시
```bash
git push origin feature/기능-이름
```

### 3️⃣ 풀 리퀘스트 생성

<details>
<summary>풀 리퀘스트 체크리스트 ✨</summary>

- [ ] 코드가 스타일 가이드라인을 따름
- [ ] 테스트 통과
- [ ] 문서 업데이트 완료
- [ ] PR 설명이 명확함
- [ ] 관련 이슈와 연결됨

</details>

## 🤝 커뮤니티 가이드라인

> 서로를 존중하며 협력해요!

- 🌟 존중과 포용을 실천해요
- 🤲 다른 사람의 학습과 성장을 도와요
- 📜 행동 강령을 준수해요
- 💡 건설적인 피드백을 제공해요
- 🏆 적절한 크레딧을 부여해요

## ❓ 도움받기

도움이 필요하신가요? 언제든 문의하세요!

- 🐛 [이슈 등록하기](https://github.com/BlockFlow/Engine/issues/new)
- 💬 [디스코드 참여하기](https://discord.gg/YOUR_INVITE_LINK)
- 📧 [@Jeonhyeonmin](https://github.com/Jeonhyeonmin)에게 연락하기
- 📚 [문서 읽어보기](https://docs.blockflow.dev)

<div align="center">
<p>Made with ❤️ by the BlockFlow community</p>
</div>
