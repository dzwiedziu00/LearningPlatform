function graDodawanie($scope) {
    $scope.gametitle = "Wykonaj mnożenie: ";
    $scope.maxNumber = 5;
    $scope.n1 = 0;
    $scope.n2 = 0;
    $scope.reloadPage = function () {
        $scope.liczbaZyc = 2;
        $scope.liczbaPkt = 0;
        $scope.wezNowePytanie();
    }

    $scope.wezNowePytanie = function () {
        $scope.n1 = Math.floor(Math.random() * $scope.maxNumber +1);
        $scope.n2 = Math.floor(Math.random() * $scope.maxNumber +1);
        $scope.question = $scope.n1 + " * " + $scope.n2;
        $scope.answer = $scope.n1 * $scope.n2;
        $scope.userAnswer = "";
    }
    $scope.sprawdzOdp = function () {
        if ($scope.userAnswer && parseInt($scope.userAnswer) == $scope.answer) {
            $scope.poprawnaOdpowiedz();
        }
    }
    $scope.potwierdzOdpowiedz = function () {
        if ($scope.userAnswer && parseInt($scope.userAnswer) == $scope.answer) {
            $scope.poprawnaOdpowiedz();
        } else {
            $scope.zlaOdpowiedz();
        }
    }

    $scope.poprawnaOdpowiedz = function () {
        $scope.liczbaPkt++;
        $scope.wezNowePytanie();
    }

    $scope.zlaOdpowiedz = function () {
        $scope.liczbaZyc--;
        if ($scope.liczbaZyc <= 0) {
            $("#lost-modal").modal();
        }
    }
    $scope.pominPytanie = function () {
        $scope.wezNowePytanie();
        $scope.liczbaPkt--;
    }
    $scope.zasieg = function (num) {
        return new Array(num);
    }
}