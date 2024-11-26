# Contributing to BlockFlow Engine 🤝

[한국어 가이드](#contributing-to-blockflow-engine-kr-)

Thank you for your interest in contributing to **BlockFlow Engine**! Your contributions help make this project better for everyone. This guide will help you get started with the contribution process.

## Table of Contents
- [Getting Started](#getting-started)
- [Development Workflow](#development-workflow)
- [Code Style Guidelines](#code-style-guidelines)
- [Submitting Changes](#submitting-changes)
- [Community Guidelines](#community-guidelines)
- [Getting Help](#getting-help)

## Getting Started

1. **Fork the Repository**
   - Click the "Fork" button in the top-right corner of the repository
   - This creates your own copy of the repository on GitHub

2. **Clone Your Fork**
   ```bash
   git clone https://github.com/your-username/BlockFlow-Engine.git
   cd BlockFlow-Engine
   ```

3. **Set Up Development Environment**
   ```bash
   # Install dependencies
   npm install

   # Set up pre-commit hooks
   npm run prepare
   ```

## Development Workflow

1. **Create a New Branch**
   ```bash
   git checkout -b feature/your-feature-name
   # or
   git checkout -b fix/your-fix-name
   ```

2. **Make Your Changes**
   - Write clean, maintainable code
   - Add comments for complex logic
   - Update documentation if needed
   - Add tests for new features

3. **Test Your Changes**
   ```bash
   # Run unit tests
   npm run test

   # Run linting
   npm run lint
   ```

## Code Style Guidelines

- Use consistent indentation (2 spaces)
- Follow the existing code style
- Write meaningful variable and function names
- Add comments for complex logic
- Keep functions small and focused
- Write unit tests for new features

## Submitting Changes

1. **Commit Your Changes**
   ```bash
   git add .
   git commit -m "feat: add new feature" # or "fix: resolve issue"
   ```

2. **Push to Your Fork**
   ```bash
   git push origin feature/your-feature-name
   ```

3. **Create a Pull Request**
   - Go to the original repository
   - Click "Pull Request"
   - Select your branch
   - Fill out the PR template
   - Add description of your changes

## Community Guidelines

- Be respectful and inclusive
- Help others when you can
- Follow the code of conduct
- Provide constructive feedback
- Give credit where it's due

## Getting Help

- Open an issue for bugs or feature requests
- Join our Discord community
- Contact maintainers (@Jeonhyeonmin)
- Check the documentation

---

# Contributing to BlockFlow Engine (KR) 🤝

[English Guide](#contributing-to-blockflow-engine-)

**BlockFlow Engine**에 기여해 주셔서 감사합니다! 여러분의 기여는 이 프로젝트를 모두에게 더 좋게 만듭니다. 이 가이드는 기여 프로세스를 시작하는 데 도움을 드릴 것입니다.

## 목차
- [시작하기](#시작하기)
- [개발 워크플로우](#개발-워크플로우)
- [코드 스타일 가이드라인](#코드-스타일-가이드라인)
- [변경사항 제출](#변경사항-제출)
- [커뮤니티 가이드라인](#커뮤니티-가이드라인)
- [도움받기](#도움받기)

## 시작하기

1. **저장소 포크하기**
   - 저장소 상단 오른쪽의 "Fork" 버튼 클릭
   - GitHub에 저장소의 개인 복사본이 생성됩니다

2. **포크 클론하기**
   ```bash
   git clone https://github.com/your-username/BlockFlow-Engine.git
   cd BlockFlow-Engine
   ```

3. **개발 환경 설정**
   ```bash
   # 의존성 설치
   npm install

   # pre-commit 훅 설정
   npm run prepare
   ```

## 개발 워크플로우

1. **새 브랜치 생성**
   ```bash
   git checkout -b feature/기능-이름
   # 또는
   git checkout -b fix/수정-이름
   ```

2. **변경사항 작업**
   - 깔끔하고 유지보수 가능한 코드 작성
   - 복잡한 로직에 주석 추가
   - 필요시 문서 업데이트
   - 새로운 기능에 대한 테스트 추가

3. **변경사항 테스트**
   ```bash
   # 단위 테스트 실행
   npm run test

   # 린팅 실행
   npm run lint
   ```

## 코드 스타일 가이드라인

- 일관된 들여쓰기 사용 (2칸 공백)
- 기존 코드 스타일 따르기
- 의미 있는 변수명과 함수명 사용
- 복잡한 로직에 주석 추가
- 함수는 작고 집중적으로 작성
- 새로운 기능에 대한 단위 테스트 작성

## 변경사항 제출

1. **변경사항 커밋**
   ```bash
   git add .
   git commit -m "feat: 새로운 기능 추가" # 또는 "fix: 문제 해결"
   ```

2. **포크에 푸시**
   ```bash
   git push origin feature/기능-이름
   ```

3. **풀 리퀘스트 생성**
   - 원본 저장소로 이동
   - "Pull Request" 클릭
   - 브랜치 선택
   - PR 템플릿 작성
   - 변경사항 설명 추가

## 커뮤니티 가이드라인

- 존중과 포용을 실천해주세요
- 가능할 때 다른 사람을 도와주세요
- 행동 강령을 준수해주세요
- 건설적인 피드백을 제공해주세요
- 적절한 크레딧을 부여해주세요

## 도움받기

- 버그나 기능 요청은 이슈로 등록해주세요
- Discord 커뮤니티에 참여해주세요
- 메인테이너에게 연락하세요 (@Jeonhyeonmin)
- 문서를 확인해보세요
