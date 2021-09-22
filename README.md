# Background Modes (Fetch) - Xamarin Forms
 Permite o aplicativo fazer algumas tarefas em segundo plano, como por exemplo <i>(baixar conteúdo regularmente da rede)</i> usando o framework cross-platform `xamarin forms`.
 
  ### Ajustes do Projeto:
  - [x] No <b>Info.plist</b> do seu aplicativo, adicione o valor `fetch` à propriedade `UIBackgroundModes` (Required background modes).
  - [x] No <b>AppDelegate.cs</b>, no método `FinishedLaunching`, adicione o seguinte código para registrar seu aplicativo para busca em segundo plano:<br/>
  `UIApplication.SharedApplication.SetMinimumBackgroundFetchInterval(10);`
  - [x] Na <b>AppDelegate.cs</b>, inclua o método `PerformFetch`.
  
 ### Sample App Background Fetch
 - Exemplo gera de tempos em tempos, um número randomico em segundo plano, sem que o aplicativo esteja aberto.
 
 ## Print Screen :foggy:
 
| ![image01](imagens/fetch-xamarin.gif) |
|:---:|
| Background Fetch - Xamarin.iOS |

### Documentação de apoio
- Background Fetch (https://github.com/Redth/iOS.BackgroundFetch.Sample)
