(function () {

    //add the following snippet before the definition of the custom controller:
    angular.module('designer').requires.push('sfSelectors');

    //definition of the custom controller
    angular.module('designer').controller('MyViewCtrl', ['$scope', 'propertyService', function ($scope, propertyService) {
        $scope.$watch(
            'selectedItem',
            function (newVal, oldVal) {
                if (!!newVal && newVal !== oldVal) {
                    $scope.properties.SelectedItem.PropertyValue = JSON.stringify(newVal);
                }
            },
            true
        );

        $scope.$watch(
            'selectedId',
            function (newVal, oldVal) {
                if (!!newVal && newVal !== oldVal) {
                    $scope.properties.SelectedId.PropertyValue = newVal;
                }
            },
            true
        );

        propertyService.get()
            .then(function (data) {
                if (data) {
                    $scope.properties = propertyService.toAssociativeArray(data.Items);

                    var serializedSelectedItem = $scope.properties.SelectedItem.PropertyValue;
                    if (serializedSelectedItem != "")
                        $scope.selectedItem = JSON.parse(serializedSelectedItem);

                    var serializedSelectedId = $scope.properties.SelectedId.PropertyValue;
                    if (serializedSelectedId != "")
                        $scope.selectedId = serializedSelectedId;
                }
            });
    }]);
})();