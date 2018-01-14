var app = angular.module('footballApp', []);

app.controller('linkController', function($scope) {
    $scope.linksList = [
        {   "title" : "Valverde nowym trenerem Barcelony!", 
            "link" : "http://footroll.pl/valverde-nowym-trenerem-barcelony/",
            "description" : "Ernesto Valverde zastąpił Luisa Enrique na stanowisku trenera FC Barcelony.",
            "votes" : 120,
            "numOfComments" : 32
        },
        {   "title" : "Lotto Ekstraklasa: Tabela po 36. kolejce.", 
            "link" : "https://sportowefakty.wp.pl/pilka-nozna/690300/lotto-ekstraklasa-tabela-po-36-kolejce-legia-nadal-liderem-co-za-emocje",
            "description" : "Legia nadal liderem! Co za emocje! Cztery prowadzące drużyny wygrały w niedzielę swoje mecze i przed ostatnią kolejką ciągle nic w lidze nie wiadomo!",
            "votes" : 98,
            "numOfComments" : 15
        },
        {   "title" : "'Bezbłędna tabela', czyli jak wyglądałaby Ekstraklasa bez błędów sędziów", 
            "link" : "http://www.gol24.pl/ekstraklasa/a/bezbledna-tabela-czyli-jak-wygladalaby-ekstraklasa-bez-bledow-sedziow-36-kolejka,12126244/",
            "description" : "W niedzielę zakończyła się przedostatnia kolejka Ekstraklasy. Wielką pomyłkę popełniła w Gdyni sędziowska ekipa Tomasza Musiała, uznając bramkę, którą ręką zdobył Rafał Siemaszko.",
            "votes" : 44,
            "numOfComments" : 22
        }
    ];

    $scope.thumbUp = function(task){
        task.votes += 1;
    };

    $scope.thumbDown = function(task){
        task.votes -= 1;
    }
});