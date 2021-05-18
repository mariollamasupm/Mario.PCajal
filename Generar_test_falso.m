% Generar Test ficticio escalonado
V_ini = 20;
V_fin = 70;
escalon = 10;
muestras = 100;
m_intermedias = 30;
ruido = 2;
trozos_pendiente = 2;
i = 0;
r = [];

for i = 1:trozos_pendiente
        a = V_ini*(i-1)/trozos_pendiente;
        b = V_ini*i/trozos_pendiente;
        r_nueva = (b-a).*rand(m_intermedias/trozos_pendiente,1) + a;  
        r = [r;r_nueva];
%        r_range = [min(r_nueva) max(r_nueva)]
end

for media = V_ini:escalon:V_fin
   
    i = i+1;
    a = media - ruido;
    b = media + ruido;
    r_nueva = (b-a).*rand(muestras,1) + a;
    r = [r;r_nueva];
    % r_range = [min(r_nueva) max(r_nueva)]  
    
    for i = 0:trozos_pendiente
        a = media + escalon*(i-1)/trozos_pendiente;
        b = media + escalon*i/trozos_pendiente;
        r_nueva = (b-a).*rand(m_intermedias/trozos_pendiente,1) + a;  
        r = [r;r_nueva];
%        r_range = [min(r_nueva) max(r_nueva)]
    end
end

save ('test_falso1.txt','r','-ascii');

% Anotaciones
%   - Falta añadir ruido aleatorio, grandes picos aislados
%   - Falta la unión de escalones