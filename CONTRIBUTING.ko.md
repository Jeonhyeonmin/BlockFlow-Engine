<h1>🔧 BlockFlow Engine 기여 가이드</h1>
<a href="http://makeapullrequest.com">
  <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square" alt="PRs Welcome" />
</a>
<a href="https://github.com/BlockFlow/Engine/graphs/contributors">
  <img src="https://img.shields.io/github/contributors/BlockFlow/Engine.svg?style=flat-square" alt="Contributors" />
</a>
<a href="https://join.slack.com/t/pulsewavestudios/shared_invite/zt-2v3951tau-yC3V494lZKfkN8x0MxZuvg">
  <img src="https://img.shields.io/badge/Join-Slack-blue.svg?style=flat-square&logo=slack" alt="Slack" />
</a>
<p>
  <a href="./CONTRIBUTING.en.md">🌏 English</a> | <a href="#-시작하기">🌏 한국어</a>
</p>

<p>🎉 BlockFlow Engine에 기여해주셔서 감사합니다! 모든 기여는 이 프로젝트를 더 좋게 만드는 데 도움이 됩니다.</p>

<h2>📚 목차</h2>
<ul>
  <li><a href="#-시작하기">🚀 시작하기</a></li>
  <li><a href="#-개발-워크플로우">💻 개발 워크플로우</a></li>
  <li><a href="#-코드-스타일-가이드라인">📝 코드 스타일 가이드라인</a></li>
  <li><a href="#-변경사항-제출">📮 변경사항 제출</a></li>
  <li><a href="#-커뮤니티-가이드라인">🤝 커뮤니티 가이드라인</a></li>
  <li><a href="#-도움받기">❓ 도움받기</a></li>
</ul>

<h2 id="-시작하기">🚀 시작하기</h2>

<h3>1️⃣ 저장소 포크하기</h3>
<p><strong>프로젝트의 개인 복사본 만들기</strong></p>
<p>포크 생성 단계</p>
<ol>
  <li>저장소 상단의 "Fork" 버튼 클릭</li>
  <li>GitHub 계정 선택</li>
  <li>포크 생성 완료 대기</li>
</ol>

<h3>2️⃣ 포크 클론하기</h3>
<pre><code># 저장소 클론
git clone https://github.com/your-username/BlockFlow-Engine.git
# 디렉토리로 이동
cd BlockFlow-Engine
</code></pre>

<h3>3️⃣ 개발 환경 설정</h3>
<pre><code># 유니티 프로젝트 열기
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
</code></pre>

<h2 id="-개발-워크플로우">💻 개발 워크플로우</h2>

<h3>1️⃣ 새 브랜치 생성</h3>
<pre><code># 새로운 기능 개발 시
git checkout -b feature/기능-이름
# 버그 수정 시
git checkout -b fix/수정-이름
</code></pre>

<h3>2️⃣ 변경사항 작업</h3>
<table>
  <thead>
    <tr>
      <th>📝 할 일</th>
      <th>ℹ️ 설명</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>깔끔한 코드</td>
      <td>유지보수가 쉽고 읽기 좋은 코드 작성</td>
    </tr>
    <tr>
      <td>문서화</td>
      <td>관련 문서 업데이트</td>
    </tr>
    <tr>
      <td>테스트</td>
      <td>새로운 기능에 대한 테스트 추가</td>
    </tr>
    <tr>
      <td>주석</td>
      <td>복잡한 로직에 대한 설명 추가</td>
    </tr>
  </tbody>
</table>

<h3>3️⃣ 변경사항 테스트</h3>
<pre><code># 유니티에서 테스트 실행
# 유니티의 테스트 기능을 이용하여 변경사항을 테스트합니다.
# 테스트는 Test Runner 창에서 실행할 수 있습니다.
# 코드 스타일 검사
# 유니티 코드 스타일 검사 도구를 사용하여 코드 스타일을 확인합니다.
# 예: EditorConfig, Code Formatter 등을 통해 스타일을 검사할 수 있습니다.
</code></pre>

<h2 id="-코드-스타일-가이드라인">📝 코드 스타일 가이드라인</h2>
<p><strong>일관성 유지를 위해 엄격한 코딩 표준을 따릅니다</strong></p>
<ul>
  <li>⚡ 들여쓰기는 2칸 공백 사용</li>
  <li>📏 기존 코드 패턴 따르기</li>
  <li>🏷️ 의미 있는 이름 사용</li>
  <li>💭 복잡한 로직에 주석 추가</li>
  <li>🎯 함수는 한 가지 역할에 집중</li>
  <li>✅ 단위 테스트 작성</li>
</ul>

<h2 id="-변경사항-제출">📮 변경사항 제출</h2>

<h3>1️⃣ 변경사항 커밋</h3>
<pre><code># 변경사항 스테이징
git add .
# 설명적인 메시지로 커밋
git commit -m "feat: 멋진 새 기능 추가"
# 또는
git commit -m "fix: 중요 버그 수정"
</code></pre>

<h3>2️⃣ 포크에 푸시</h3>
<pre><code>git push origin feature/기능-이름</code></pre>

<h3>3️⃣ 풀 리퀘스트 생성</h3>
<p><strong>풀 리퀘스트 체크리스트 ✨</strong></p>
<ul>
  <li>[ ] 코드가 스타일 가이드라인을 따름</li>
  <li>[ ] 테스트 통과</li>
  <li>[ ] 문서 업데이트 완료</li>
  <li>[ ] PR 설명이 명확함</li>
  <li>[ ] 관련 이슈와 연결됨</li>
</ul>

<h2 id="-커뮤니티-가이드라인">🤝 커뮤니티 가이드라인</h2>
<p><strong>서로를 존중하며 협력해요!</strong></p>
<ul>
  <li>🌟 존중과 포용을 실천해요</li>
  <li>🤲 다른 사람의 학습과 성장을 도와요</li>
  <li>📜 행동 강령을 준수해요</li>
  <li>💡 건설적인 피드백을 제공해요</li>
  <li>🏆 적절한 크레딧을 부여해요</li>
</ul>

<h2 id="-도움받기">❓ 도움받기</h2>
<p>도움이 필요하신가요? 언제든 문의하세요!</p>
<ul>
  <li>🐛 <a href="https://github.com/BlockFlow/Engine/issues/new">이슈 등록하기</a></li>
  <li>💬 <a href="https://join.slack.com/t/pulsewavestudios/shared_invite/zt-2v3951tau-yC3V494lZKfkN8x0MxZuvg">슬랙 참여하기</a></li>
  <li>📧 <a href="https://github.com/Jeonhyeonmin">@Jeonhyeonmin</a>에게 연락하기</li>
  <li>📚 <a href="https://docs.blockflow.dev">문서 읽어보기</a></li>
</ul>

<p>Made with ❤️ by the BlockFlow community</p>
