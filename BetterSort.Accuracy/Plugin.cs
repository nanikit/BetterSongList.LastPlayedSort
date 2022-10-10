namespace BetterSort.Accuracy {
  using BetterSort.Common.Compatibility;
  using BetterSort.Common.External;
  using BetterSort.Accuracy.External;
  using BetterSort.Accuracy.Sorter;
  using IPA;
  using Zenject;
  using IPALogger = IPA.Logging.Logger;

  [Plugin(RuntimeOptions.SingleStartInit)]
  public class Plugin {
    /// <summary>
    /// Called when the plugin is first loaded by IPA (either when the game starts or when the plugin is enabled if it starts disabled).
    /// [Init] methods that use a Constructor or called before regular methods like InitWithConfig.
    /// Only use [Init] with one Constructor.
    /// </summary>
    [Init]
    public void Setup(IPALogger logger) {
      _logger = logger;
    }

    [OnStart]
    public void Initialize() {
      if (_logger == null) {
        return;
      }
      _logger.Debug("Initialize()");

      //var container = ProjectContext.Instance.Container.CreateSubContainer();
      //container.BindInterfacesAndSelfTo<IPALogger>().FromInstance(_logger).AsSingle();
      //container.BindInterfacesAndSelfTo<Clock>().AsSingle();

      //container.Bind<AccuracyRepository>().AsSingle();

      //container.BindInterfacesAndSelfTo<AccuracySorter>().AsSingle();
      //container.Bind<FilterSortAdaptor>().AsSingle();
      //container.Bind<SorterEnvironment>().AsSingle();

      //var environment = container.Resolve<SorterEnvironment>();
      //environment.Start(true);

      _logger.Info("Initialized.");
    }

    [OnExit]
    public void OnExit() {
      // No op, just for suppressing BSIPA confirm.
    }

    private IPALogger? _logger;
  }
}
