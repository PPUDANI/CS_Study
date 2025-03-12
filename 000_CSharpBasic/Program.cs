/*
 * >> C#의 컴파일 과정
 *   - C# 코드는 C# 컴파일러(CSC, Roslyn 등)에 의해 중간 언어(IL, Intermediate Language)로 변환됨.
 *   - IL 코드는 .NET 런타임 환경에서 실행되며, 실행 방식에는 JIT(Just-In-Time) 및 AOT(Ahead-of-Time) 컴파일이 있음.
 *   - .NET 런타임 환경에는 CLR(Common Language Runtime), Mono, CoreCLR 등이 있으며, 플랫폼 및 환경에 따라 적절한 런타임이 선택됨.
 *
 * 
 * >> C# 컴파일러 종류
 *   - Roslyn(CSC) : 최신 C# 컴파일러로, .NET Framework 및 .NET Core에서 사용됨.
 *   - Mono C# 컴파일러 : Mono 런타임에서 사용되는 C# 컴파일러.
 *   - IL2CPP : Unity에서 사용하는 변환 도구로, IL 코드를 C++ 코드로 변환한 후 네이티브 코드로 컴파일함.
 *
 *
 * >> CLR(Common Language Runtime)
 *   - .NET 런타임 환경으로, C#으로 작성된 프로그램을 실행할 수 있도록 지원함.
 *   - IL 코드를 JIT 또는 AOT 방식으로 네이티브 코드로 변환하여 실행함.
 *   - Windows에서는 CLR이, 크로스플랫폼 환경에서는 .NET Core의 CoreCLR이 사용됨.
 *
 *
 * >> Mono Runtime
 *   - Mono는 오픈소스 .NET 구현체로, 주로 Unity 및 모바일 플랫폼에서 사용됨.
 *   - IL 코드를 JIT 또는 AOT 방식으로 변환하여 실행함.
 *   - Unity에서는 Mono JIT 또는 IL2CPP를 사용하여 실행함.
 *
 *
 * >> JIT(Just-In-Time) 컴파일
 *   - 실행 시점에서 IL 코드를 네이티브 코드로 변환하는 동적 컴파일 방식.
 *   - PC 및 고성능 환경에서는 JIT를 사용하여 최적화를 수행함.
 *   - 런타임에서 코드 최적화(인라이닝, 루프 언롤링 등)를 적용하여 성능을 향상시킴.
 *
 *
 * >> AOT(Ahead-of-Time) 컴파일
 *   - 실행 전에 IL 코드를 미리 네이티브 코드로 변환하는 방식.
 *   - 모바일(iOS 등) 및 콘솔 플랫폼에서 JIT를 사용할 수 없는 경우 AOT를 사용함.
 *   - Unity에서는 IL2CPP를 사용하여 AOT 컴파일을 수행함.
 *
 *
 * >> Unity에서의 C# 코드 실행 방식
 *   - Unity는 기본적으로 Mono 또는 IL2CPP를 사용하여 C# 코드를 실행함.
 *   - 에디터 및 PC 플랫폼에서는 Mono JIT을 사용하여 빠른 개발과 디버깅을 지원함.
 *   - iOS 및 콘솔에서는 IL2CPP를 사용하여 C++로 변환 후 네이티브 컴파일(AOT)하여 실행함.
 *   - Android의 경우 Mono JIT 또는 IL2CPP 중 선택 가능함.
 *
 *
 * >> 플랫폼별 Unity 실행 방식 정리
 *   - 플랫폼	기본 실행 방식	대체 옵션
 *   - Unity 에디터(PC, macOS)	Mono JIT	IL2CPP 가능
 *   - Windows, macOS, Linux (Standalone 빌드)	Mono JIT	IL2CPP 가능
 *   - iOS	IL2CPP (AOT)	없음 (JIT 불가)
 *   - Android	Mono JIT	IL2CPP 가능
 *   - 콘솔 (PS, Xbox, Switch 등)	IL2CPP (AOT)	없음
 *   - WebGL	IL2CPP (AOT)	없음 (JIT 불가)

 */
