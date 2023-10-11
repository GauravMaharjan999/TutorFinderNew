var MaleCount = $("#MaleStudentCount").val();
var FemaleCount = $("#FemaleStudentCount").val();
var OtherStudentCount = $("#OtherStudentCount").val();


/*-------------------------------------
      Doughnut Chart 
  -------------------------------------*/
if ($("#DashboardStudent-doughnut-chart").length) {


    
    var doughnutChartData = {
        labels: ["Female Students", "Male Students", "Other Students"],
        datasets: [{
            backgroundColor: ["#304ffe", "#ffa601", "#dc3545"],
            data: [MaleCount, FemaleCount, OtherStudentCount,0],
            label: "Total Students"
        },]
    };
    var doughnutChartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        cutoutPercentage: 65,
        rotation: -9.4,
        animation: {
            duration: 2000
        },
        legend: {
            display: false
        },
        tooltips: {
            enabled: true
        },
    };
    var studentCanvas = $("#DashboardStudent-doughnut-chart").get(0).getContext("2d");
    var studentChart = new Chart(studentCanvas, {
        type: 'doughnut',
        data: doughnutChartData,
        options: doughnutChartOptions
    });
}



/*-------------------------------------
      Bar Chart 
  -------------------------------------*/
if ($("#DasboardStudentGender-bar-chart").length) {

    var barChartData = {
        labels: ["Male", "Female", "Others"],
        datasets: [{
            backgroundColor: ["#40dfcd", "#417dfc", "#ffaa01"],
           /* data: [125,100, 75, 50, 25],*/
            data: [MaleCount, FemaleCount, OtherStudentCount],
            label: "Students Gender"
        },]
    };
    var barChartOptions = {
        responsive: true,
        maintainAspectRatio: false,
        animation: {
            duration: 2000
        },
        scales: {

           
             yAxes: [{
                display: true,
                 ticks: {
                     min:0
                 }
            }],

           /* xAxes: [{
                display: false,
                maxBarThickness: 100,
                ticks: {
                    display: false,
                    padding: 0,
                    fontColor: "#646464",
                    fontSize: 14,
                },
                gridLines: {
                    display: true,
                    color: '#e1e1e1',
                }
            }],
            yAxes: [{
                display: true,
                ticks: {
                    display: true,
                    autoSkip: false,
                    fontColor: "#646464",
                    fontSize: 14,
                    stepSize: 25000,
                    padding: 20,
                    beginAtZero: true,
                    callback: function (value) {
                        var ranges = [{
                            divider: 1e6,
                            suffix: 'M'
                        },
                        {
                            divider: 1e3,
                            suffix: 'k'
                        }
                        ];

                        function formatNumber(n) {
                            for (var i = 0; i < ranges.length; i++) {
                                if (n >= ranges[i].divider) {
                                    return (n / ranges[i].divider).toString() + ranges[i].suffix;
                                }
                            }
                            return n;
                        }
                        return formatNumber(value);
                    }
                },
                gridLines: {
                    display: true,
                    drawBorder: true,
                    color: '#e1e1e1',
                    zeroLineColor: '#e1e1e1'

                }
            }]*/
        },
        legend: {
            display: false
        },
        tooltips: {
            enabled: true
        },
        elements: {}
    };
    var expenseCanvas = $("#DasboardStudentGender-bar-chart").get(0).getContext("2d");
    var expenseChart = new Chart(expenseCanvas, {
        type: 'bar',
        data: barChartData,
        options: barChartOptions
    });
}
