# AFK Samurai Shodown

Unity 2D 방치형 게임 프로젝트

## 프로젝트 개요

AFK Samurai Shodown은 Samurai Shodown 테마의 2D 방치형(Idle) 게임입니다. 플레이어는 다양한 사무라이 캐릭터들을 수집하고, 자동으로 진행되는 전투를 통해 스테이지를 클리어하며 진행하는 게임입니다.

## 게임 특징

### 방치형 게임플레이
- 플레이어 캐릭터가 자동으로 적을 탐지하고 공격
- 적이 없을 때 자동으로 오른쪽으로 이동
- 스테이지 끝에 도달하면 자동으로 다음 스테이지로 진행

### 캐릭터 수집 시스템
- 4명의 고유한 사무라이 캐릭터
- 각 캐릭터마다 고유한 능력치와 스킬
- 캐릭터별 원거리 공격 지원

### 스테이지 진행 시스템
- 점진적으로 어려워지는 스테이지 구성
- 보스 스테이지 (50스테이지)
- 다양한 배경 맵 제공

## 프로젝트 구조

### Scripts 폴더 구조

```
Scripts/
├── Character/          # 캐릭터 관련 스크립트
│   ├── Character.cs           # 기본 캐릭터 클래스
│   ├── Main_Character.cs      # 플레이어 캐릭터
│   ├── Enemy.cs              # 적 캐릭터
│   ├── Projectile.cs         # 투사체 시스템
│   ├── CharacterList.cs      # 캐릭터 데이터 관리
│   └── Referee.cs            # 심판 시스템
├── Manager/           # 게임 매니저들
│   ├── GameManager.cs        # 전체 게임 상태 관리
│   ├── StageManager.cs       # 스테이지 진행 관리
│   └── CharacterManager.cs   # 캐릭터 초기화 관리
├── Stage/             # 스테이지 관련
│   ├── EnemySpawner.cs       # 적 스폰 관리
│   ├── PlayerSpawner.cs      # 플레이어 위치 설정
│   └── EndOfStage.cs         # 스테이지 클리어 처리
├── UI/                # UI 시스템
│   ├── MainUI.cs             # 메인 UI 관리
│   ├── CharacterSlot.cs      # 캐릭터 슬롯 UI
│   ├── HpBar.cs             # HP바 시스템
│   └── StageIndicator.cs     # 스테이지 표시
├── CameraController.cs       # 카메라 제어
└── SpriteSorter.cs          # 2D 스프라이트 정렬
```

## 주요 시스템

### 캐릭터 시스템
- **Character**: 모든 캐릭터의 기본 클래스
  - HP, 공격력, 방어력, 공격 딜레이, 이동속도, 공격 범위
  - 이동, 공격, 사망 로직
- **Main_Character**: 플레이어 캐릭터 (자동 AI)
- **Enemy**: 적 캐릭터 (플레이어 탐지 및 공격)

### 스테이지 시스템
- **StageManager**: 스테이지 진행, 맵 로딩, 적 스폰 관리
- **EnemySpawner**: 오브젝트 풀링을 통한 적 캐릭터 관리
- **PlayerSpawner**: 플레이어 캐릭터 위치 설정

### UI 시스템
- **MainUI**: 메인 UI 관리 및 스테이지 표시
- **CharacterSlot**: 캐릭터 정보 표시 (이미지, HP바)
- **HpBar**: 실시간 HP 표시 시스템

### 2D 그래픽 시스템
- **SpriteSorter**: Y축 기반 스프라이트 정렬로 깊이감 구현
- **CameraController**: 플레이어 추적 카메라
- **애니메이션**: 이동, 공격, 피격, 사망 애니메이션

## 게임플레이

### 스테이지 진행
1. **1-9스테이지**: 쉬운 적 1마리
2. **10-49스테이지**: 쉬운 적 2마리
3. **50스테이지**: 보스 + 쉬운 적 2마리
4. **51-99스테이지**: 쉬운 적 3-4마리
5. **100스테이지 이후**: 더 강한 적들

### 캐릭터 목록
- **Haohmaru** (하오마루)
- **Dokan Ota** (도칸 오타)
- **Holy Beast Soldier** (성수병)
- **Musashi Miyamoto** (무사시 미야모토)

### 맵 목록
- BorderStage
- BuddhaStage
- BusyDoju
- EmptyDoju
- UkoyStage

## 설치 및 실행

1. Unity 2022.x 이상 버전 설치
2. 프로젝트 폴더를 Unity로 열기
3. Main Scene.unity 씬 실행
4. Play 버튼으로 게임 시작

## 라이선스

이 프로젝트는 교육 및 학습 목적으로 제작되었습니다.
