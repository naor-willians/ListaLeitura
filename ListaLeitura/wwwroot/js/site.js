$(document).ready(function () {
    $('#ListaLeitura').DataTable({
        language: {
            "decimal": "",
            "emptyTable": "Sem leituras encontradas na tabela",
            "info": "Mostrando _START_ a _END_ de _TOTAL_ leituras",
            "infoEmpty": "Mostrando 0 a 0 de 0 leituras",
            "infoFiltered": "(filtered from _MAX_ total entries)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar _MENU_ leitura",
            "loadingRecords": "Carregando...",
            "processing": "",
            "search": "Procurar:",
            "zeroRecords": "Sem leituras encontradas",
            "paginate": {
                "first": "Primeiro",
                "last": "Último",
                "next": "Próximo",
                "previous": "Anterior"
            },
            "aria": {
                "orderable": "Order by this column",
                "orderableReverse": "Reverse order this column"
            }
        }
    });

    setTimeout(function () {
        $(".alert").fadeOut("slow", function () {
            $(this).alert('close');
        })
    }, 5000)
})