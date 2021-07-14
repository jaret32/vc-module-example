// Call this to register your module to main application
var moduleName = "example";

if (AppDependencies !== undefined) {
    AppDependencies.push(moduleName);
}

angular.module(moduleName, [])
    .config(['$stateProvider',
        function ($stateProvider) {
            $stateProvider
                .state('workspace.exampleState', {
                    url: '/example',
                    templateUrl: '$(Platform)/Scripts/common/templates/home.tpl.html',
                    controller: [
                        'platformWebApp.bladeNavigationService', function (bladeNavigationService) {
                            var newBlade = {
                                id: 'blade1',
                                controller: 'example.helloWorldController',
                                template: 'Modules/$(example)/Scripts/blades/hello-world.html',
                                isClosingDisabled: true
                            };
                            bladeNavigationService.showBlade(newBlade);
                        }
                    ]
                });
        }
    ])

    .run(['platformWebApp.mainMenuService', 'platformWebApp.widgetService', '$state',
        function (mainMenuService, widgetService, $state) {
            //Register module in main menu
            var menuItem = {
                path: 'browse/example',
                icon: 'fa fa-cube',
                title: 'ExampleModule',
                priority: 100,
                action: function () { $state.go('workspace.exampleState'); },
                permission: 'example:access'
            };
            mainMenuService.addMenuItem(menuItem);
        }
    ]);
