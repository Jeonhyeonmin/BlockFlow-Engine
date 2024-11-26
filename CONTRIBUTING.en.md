🔧 BlockFlow Engine 기여 가이드
PRs Welcome
Contributors
Slack
🌏 English | 🌏 한국어

🎉 BlockFlow Engine에 기여해주셔서 감사합니다! 모든 기여는 이 프로젝트를 더 좋게 만드는 데 도움이 됩니다.

📚 목차
🚀 시작하기
💻 개발 워크플로우
📝 코드 스타일 가이드라인
📮 변경사항 제출
🤝 커뮤니티 가이드라인
❓ 도움받기
🚀 시작하기
1️⃣ 저장소 포크하기
프로젝트의 개인 복사본 만들기

포크 생성 단계

저장소 상단의 "Fork" 버튼 클릭
GitHub 계정 선택
포크 생성 완료 대기
2️⃣ 포크 클론하기
# 저장소 클론
git clone https://github.com/your-username/BlockFlow-Engine.git
# 디렉토리로 이동
cd BlockFlow-Engine
3️⃣ 개발 환경 설정
# 유니티 프로젝트 열기
# Unity Hub에서 BlockFlow-Engine 프로젝트를 열어주세요.
# 의존성 설치
# Unity Package Manager에서 필요한 모든 패키지를 설치합니다.
# 백엔드 및 Photon 설정
# 프로젝트 설정 파일(backend.json, photon.json)을 구성해 서버와 연결합니다.
{
  "backend": {
    "projectName": "BlockFlow",
    "serverRegion": "Asia",
    "authentication": {
      "method": "JWT",
      "timeout": 3600
    }
  },
  "photon": {
    "networkProtocol": "UDP",
    "serverSettings": {
      "maxPlayers": 50,
      "timeout": 5000
    }
  }
}
💻 개발 워크플로우
1️⃣ 새 브랜치 생성
# 새로운 기능 개발 시
git checkout -b feature/기능-이름
# 버그 수정 시
git checkout -b fix/수정-이름
2️⃣ 변경사항 작업
📝 할 일	ℹ️ 설명
깔끔한 코드	유지보수가 쉽고 읽기 좋은 코드 작성
문서화	관련 문서 업데이트
테스트	새로운 기능에 대한 테스트 추가
주석	복잡한 로직에 대한 설명 추가
3️⃣ 변경사항 테스트
# 유니티에서 테스트 실행
# 유니티의 테스트 기능을 이용하여 변경사항을 테스트합니다.
# 테스트는 Test Runner 창에서 실행할 수 있습니다.
# 코드 스타일 검사
# 유니티 코드 스타일 검사 도구를 사용하여 코드 스타일을 확인합니다.
# 예: EditorConfig, Code Formatter 등을 통해 스타일을 검사할 수 있습니다.
📝 코드 스타일 가이드라인
일관성 유지를 위해 엄격한 코딩 표준을 따릅니다

⚡ 들여쓰기는 2칸 공백 사용
📏 기존 코드 패턴 따르기
🏷️ 의미 있는 이름 사용
💭 복잡한 로직에 주석 추가
🎯 함수는 한 가지 역할에 집중
✅ 단위 테스트 작성
📮 변경사항 제출
1️⃣ 변경사항 커밋
# 변경사항 스테이징
git add .
# 설명적인 메시지로 커밋
git commit -m "feat: 멋진 새 기능 추가"
# 또는
git commit -m "fix: 중요 버그 수정"
2️⃣ 포크에 푸시
git push origin feature/기능-이름
3️⃣ 풀 리퀘스트 생성
풀 리퀘스트 체크리스트 ✨

 코드가 스타일 가이드라인을 따름
 테스트 통과
 문서 업데이트 완료
 PR 설명이 명확함
 관련 이슈와 연결됨
🤝 커뮤니티 가이드라인
서로를 존중하며 협력해요!

🌟 존중과 포용을 실천해요
🤲 다른 사람의 학습과 성장을 도와요
📜 행동 강령을 준수해요
💡 건설적인 피드백을 제공해요
🏆 적절한 크레딧을 부여해요
❓ 도움받기
도움이 필요하신가요? 언제든 문의하세요!

🐛 이슈 등록하기
💬 슬랙 참여하기
📧 @Jeonhyeonmin에게 연락하기
📚 문서 읽어보기
Made with ❤️ by the BlockFlow community
