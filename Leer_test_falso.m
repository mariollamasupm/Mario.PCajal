%% VARIABLES IMPORTANTES:
r = 0.05;     % ruido permitido en porcentaje
windowSize = 30;

%% Leer test falso :

fileID = fopen('test_falso1.txt');      % Abrimos el archivo (A)
A = fscanf(fileID,'%f');
fclose(fileID);

size_a = size(A);                       % N = matriz de 0 a nºmedidas
N = 1:size_a(1);

 figure;                                 % Graficamos  
 plot (N,A)
 axis tight
 
%% Filtro

b = (1/windowSize)*ones(1,windowSize);
y = filter(b,1,A);
delay = (length(b)-1)/2;

figure;
plot (N,A, '-g')
hold on
plot(N-delay,y,'-b','LineWidth',2)
axis tight
legend('Input Data','Filtered Data','Location','northwest')

%% Señal filtrada
figure
plot(N,y)
axis tight

%% Encontrar ventanas

j = 0;
ptos_caract = [];
t = [];
n2 = 1;
size_y = size(y);
size_y = size_y(1);

while j<size_y
    j = j+1;
    m = y(j);
    n2 = 1;
    while j<size_y && y(j) > m-r*m && y(j+1) < m+r*m
        n2 = n2+1;
        m = (m*(n2-1)+y(j+1))/n2;
        j = j+1;
    end
    if n2 >= windowSize
        ptos_caract = [ptos_caract;m];
        t = [t;j-(n2/2)];
    end
end

figure
plot(N,y)
hold on
plot(t,ptos_caract,'-*')
axis tight

%% Resultado
figure;
plot (N,A, '-g')
hold on
plot(N-delay,y,'-b','LineWidth',2)
hold on
plot(t-delay,ptos_caract,'-*','LineWidth',2)

axis tight
legend('Input Data','Filtered Data','characteristic line','Location','northwest')

%% Generar recta característica (Regresión lineal)

p = polyfit(t,ptos_caract,1)
x = [0;t;size_y];
x_p = polyval(p,x);

figure
plot(x,x_p,'-o')
axis tight

%% Recta caract a lo bruto
p1 = polyfit (N,y,1)
% yp = polyval(p1,N);
% figure
% plot(N,yp)
% axis tight

%% Recta muy bruta
p2 = polyfit (N,A,1)

%% Ajustar origen


%% Ajustar pendiente

