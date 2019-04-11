insert into dbo.Features
(Name)
select 'Airbag' union all
select 'Alarme' union all
select 'Ar quente' union all
select 'Banco com regulagem de altura' union all
select 'CD Player' union all
select 'Computador de bordo' union all
select 'Controle de tração' union all
select 'Desembaçador traseiro' union all
select 'Ar condicionado' union all
select 'Encosto de cabeça traseiro' union all
select 'Freio ABS' union all
select 'Controle automático de velocidade' union all
select 'Rádio' union all
select 'Retrovisores elétricos' union all
select 'Rodas de liga leve' union all
select 'Travas elétricas' union all
select 'Vidros elétricos' union all
select 'Volante com regulagem de altura'

insert into dbo.Makes
(Name)
select 'Volkswagen' union all
select 'Citroen' union all
select 'Peugeot' union all
select 'Jaguar' union all
select 'Fiat' union all
select 'Honda' union all
select 'Toyota' union all
select 'Chevrolet' union all
select 'Ford'

insert into dbo.Models
(Name, MakeId)
select 'Gol', 1 union all
select 'Golf', 1 union all
select 'Polo', 1 union all
select 'C3', 2 union all
select 'C4', 2 union all
select '206', 3 union all
select '308', 3 union all
select 'F-Pace', 4 union all
select 'Uno', 5 union all
select 'Civic', 6 union all
select 'City', 6 union all
select 'Fit', 6 union all
select 'Hilux', 7 union all
select 'Corolla', 7 union all
select 'Celta', 8 union all
select 'Camaro', 8 union all
select 'Focus', 9