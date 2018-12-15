# Apresentação
Uma das ferramentas que mais me chamou a atenção quando conheci. Pura empolgação.

**"O céu não é o limite"** kkkkkkk.

Com o dnSpy você pode abrir um Assembly, editar, debugar e recompilar tornando um novo assembly. Isso sem necessitar do código fonte, com exigências de apenas as  dependências do assembly.

É uma ferramenta mais poderosa do que o ILSpy, também com objetivos diferentes, porém a grande sacada é que o ILSpy é uma de suas dependências.

# dnSpy
Novamente uma ferramenta Open Source, com possibilidades de estudar o código, aprender muito, e fazer suas próprias versões.

Uma ferramenta para você fazer debug, editar e recompilar assemblies, mesmo que você não tenha o código fonte disponível. Isso não é maravilhoso?

Veja o vídeo tutorial que eu fiz para você:

## Vídeo
Aqui fica o vídeo

## Links
Aqui fica os links
Wiki https://github.com/0xd4d/dnSpy/wiki
GitHub https://github.com/0xd4d/dnSpy
Releases https://github.com/0xd4d/dnSpy/releases


## Funcionalidades
- Debug .NET Framework, .NET Core e Unity Game assemblies, sem necessidade do código fonte.
- Breakpoints e passo a passo dentro do assembly.
- Edite assemblies em C#, Visual Basic ou IL (Intermediate Language), inclusive recompile-os.
- Adicione novos métodos, classes, membros, etc.
- Hex editor se necessário.
- Muito muito mais, veja a [documentação](https://github.com/0xd4d/dnSpy) ...

# Caso de uso
Já "salvei vidas" com ela, e me rendeu um bom aproveitamento de tempo para outras atividades. O caso que conto, aconteceu comigo quando uma aplicação estava em produção gerando erro. 

Esta aplicação era granulada em uma série de DLL's que compõe o conjunto maior da aplicação, ou seja, as DLL's neste caso eram consumidas via reflection como dependências.

Com a ferramenta dnSpy, editei o assembly, fiz o Debug até o ponto de exception, e percebi que uma DLL estava em versão incorreta, com chamadas de código inconpatível, não existente em outras dependências. Veriquei no controle de fontes, e havia um gap de versão, aparentemente a DLL foi compilada sem fechamento, um erro versão. 

Para não parar o software em produção (já estava parado kkkkk), e o cliente seguir em funcionamento; com o dnSpy, fiz o procedimento de correção, injetando novos códigos e comentando outros, e assim recompilei a mesma DLL.

Funcionou perfeitamente, o produto voltou a rodar sem exception e seguiu o processo. Obviamente que foi agendado uma nova versão de atualização para o cliente em uma versão fechada publicada, mas de qualquer forma o dnSpy foi um meio paiativo que "salvou vidas" kkkkk.

# Espertinhos de prontidão
É obvio sem dúvidas que a primeira coisa que uma mente nerd negra pensa sobre isso, é crackear aplicações desenvolvidas sobre o .Net Framework kkkkkkkkkkkk. 

O pior, é que pode ser feito sim, por exemplo: pular um login, remover uma validação de licença, editar um jogo e aumentar suas habilidades, etc, criativade é o que não falta.

Mas, nem tudo são flores. Há meios de evitar estes problemas, mas meu sentimento é que 99% das empresas não pensam nisso. Deixarei em outra oportunidade para explicar os meios de proteger seu código e contra um disassembler.
