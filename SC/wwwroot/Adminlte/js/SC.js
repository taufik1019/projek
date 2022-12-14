$(document).ready(function () {
    $('#KeluhanTable').DataTable({
        "sDom": "Bfrtip",
        "buttons": [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        "columnDefs": [
            {
                searchable: true,
                orderable: false,
                targets: 0,
            },
        ]
    });
});

$(document).ready(function () {
    $('#MhsTable').DataTable({
        "sDom": "Bfrtip",
        "buttons": [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        "columnDefs": [
            {
                searchable: true,
                orderable: false,
                targets: 0,
            },
        ]
    });
});

$(document).ready(function () {
    $('#ResponTable').DataTable({
        "sDom": "Bfrtip",
        "buttons": [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ],
        "columnDefs": [
            {
                searchable: true,
                orderable: false,
                targets: 0,
            },
        ]
    });
});