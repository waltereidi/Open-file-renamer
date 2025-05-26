<article>
    <h1>
        Open file renamer
    </h1>
    <ol>
        <li>
            História do open file renamer
        </li>
        <li>
            Arquitetura
        </li>
        <li>
            Instruções para desenvolvimento
        </li>
        <li>
            Post mortem
        </li>
    </ol>
    <p data-foo="bar">
        &nbsp;
    </p>
    <h2>
        1. História do Open file renamer
    </h2>
    <p style="margin-left:40px;" data-foo="bar">
        O open file rename nasceu como uma proposta de estudos windowsform auto-didata e foi finalizada para ser entregue á um trabalho de pós graduação em desenvolvimento full stack.
    </p>
    <p style="margin-left:40px;" data-foo="bar">
        &nbsp;
    </p>
    <p style="margin-left:40px;" data-foo="bar">
        &nbsp;
    </p>
    <h2>
        2. Arquitetura
    </h2>
    <p style="margin-left:40px;">
        Sua arquitetura foi planejada para ter um backend que comporte várias interfaces de usuário pertencentes á linguagem C# e .NET, todas as respostas da camada de presentação devem ser entregues pela camada de serviço e a camada de serviço se comunica e organiza todos os micro-serviços.
    </p>
    <h3 style="margin-left:40px;">
        Estrutura da camada de Aplicação :&nbsp;
    </h3>
    <h3 style="margin-left:40px;">
        Services&nbsp;
    </h3>
    <p style="margin-left:40px;">
        – <strong>Services </strong>“Serviços que fazem a orquestração de solicitações da presentação e micro-serviços”<br>
        — <strong>Contracts </strong>“Contratos de comunicação que devem ser atendidos pela camada de presentação”<br>
        — <strong>DAO&nbsp;</strong>“Objetos de acessos á dados, aqui se delega o máximo que se pode de lógica utilizada nos componentes da presentação”<br>
        — <strong>DTO</strong> “Classes magras utilizadas para armazenar estrutura de dados comuns”<br>
        — <strong>Enum </strong>“Páginas do tipo Enum”<br>
        — <strong>Interfaces </strong>“Interfaces utilizadas na camada de serviço e presentação”<br>
        — <strong>Value Objects</strong> “Objetos imutáveis que estabelecem a linguagem ubiqua para símbolos utilizados no projeto”
    </p>
    <h3 style="margin-left:40px;">
        Estrutura do micro serviço File Manager
    </h3>
    <h3 style="margin-left:40px;">
        File Manager
    </h3>
    <p style="margin-left:40px;">
        – <strong>File Manager</strong> “Aqui deve ficar páginas cujo a chamada pertence á serviços externos”<br>
        —<strong> DAO </strong>“Objetos que fazem acesso á dados externos”<br>
        — <strong>DirectoryOperations </strong>“Operações destinados apenas á leitura de diretórios”<br>
        — <strong>File Operations &nbsp;</strong>“Operações que modificam arquivos físicos”<br>
        — — <strong>Append </strong>“Adicionar caracteres”<br>
        — — <strong>NumberedSequence </strong>“Sequencia numérica”<br>
        — — <strong>Pattern </strong>“Padrão de substituição de caracteres”<br>
        — — <strong>Remove </strong>“Remoção de caracteres”<br>
        — <strong>Interfaces </strong>“Interfaces”
    </p>
    <p style="margin-left:40px;">
        &nbsp;
    </p>
    <h2>
        3. Instruções para desenvolvimento
    </h2>
    <h4 style="margin-left:40px;">
        Acesso á arquivos físicos :&nbsp;
    </h4>
    <p style="margin-left:40px;">
        O acesso de arquivos físicos deve ser feito através da classe <strong>FileManager.DAO.FileIdentity</strong>,<strong> </strong>o acesso deve ser uma única fonte da verdade e imutável, desta forma será possível facilitar as operações de rollback , renomeação de arquivos&nbsp;<strong> </strong>e leitura.&nbsp;<br>
        É importante notar que a classe FileIdentity deve ser interpretada como uma identidade única para o arquivo antes e depois de modificar seu nome, enquanto ainda estiver no mesmo diretório, desta forma será possível encontrá-lo para retornar á sua última versão.<br>
        A pratica de utilização de <strong>ValueObjects </strong>vai evitar sinónimos e vários bugs durante o processo de desenvolvimento.<br>
        ( referencias "Desenvolvimento guiado por testes TDD, Kent Beck ISBN 978-85-7780-747-5 ")
    </p>
    <p style="margin-left:40px;">
        &nbsp;
    </p>
    <h4 style="margin-left:40px;">
        Adicionar novas operações de renomeação de arquivos :&nbsp;<br>
        &nbsp;
    </h4>
    <h5 style="margin-left:40px;">
        1 -Adicione uma operação de renomear arquivos :&nbsp;
    </h5>
    <p style="margin-left:40px;">
        Novas operações de renomeação devem utilizar-se da classe base :<strong> FileManager.FileOperations.FileProcessor</strong>, a classe utiliza o padrão GOF "Strategy" e é implementada á classe<strong> FileManager.FileOperations.FileWriter.</strong><br>
        O método abstrato GetRenameTo() deve retornar o novo nome de arquivo que será implementado em preview, renomeação e rollback de nome de arquivo, adicione ao construtor desta classe as dependencias da classe pai e demais variáveis necessárias para construir o novo nome do arquivo.<br>
        <strong>Importante : </strong>Utilize os atributes da classe pai “FileNameBefore” e “FileExtensionBefore” para reconstruir o nome do arquivo.<br>
        &nbsp;
    </p>
    <h5 style="margin-left:40px;">
        2 - Implemente a operação de renomear arquivo em <strong>FileManagerService</strong>&nbsp;
    </h5>
    <p style="margin-left:40px;">
        A classe <strong>FileManager.FileManagerService</strong> deve implementar todas as operações que estão expostas á camada de serviço, Operações de Leitura de arquivos devem estar contidas na interface <strong>IDirectoryReader </strong>e Operações relacionadas ao versionamento de arquivos na interface <strong>IVersionControl.&nbsp;</strong><br>
        Note que todas as operações que modificam o nome de arquivos estão isentas de interface mas são intermediadas pela interface <strong>IMementoFileManager, </strong>que implementa o Design Pattern GOF Memento para armazenar a última modificação de arquivo feita.<br>
        &nbsp;
    </p>
    <h5 style="margin-left:40px;">
        3 - Adicione uma chamada á o serviço implementado no projeto FileManager na camada de serviço
    </h5>
    <p style="margin-left:40px;">
        Agora faça a implementação necessária para utilizar o serviço na camada de serviço, pode-se utilizar das implementações já existentes ou delegar da forma que for necessário a camada de presentação.<br>
        &nbsp;
    </p>
    <p style="margin-left:40px;">
        &nbsp;
    </p>
    <h4 style="margin-left:40px;">
        Camada de Presentação Windows Forms
    </h4>
    <p style="margin-left:40px;">
        &nbsp;
    </p>
    <h5 style="margin-left:40px;">
        1 - Filtros&nbsp;<br>
        &nbsp;
    </h5>
           ![image](https://github.com/user-attachments/assets/b18723d9-1ab0-43e2-94b6-94fe4bba15eb)
    <p style="margin-left:40px;">
        Implemente novos tipos de filtros enviando um evento para o método privado : <strong>searchFilter_Changed </strong>da classe <strong>Presentation.Main,</strong><br>
        adicione um novo tipo de Enum em <strong>ApplicationService.Enum.Main_SearchFilter</strong> e implemente uma nova leitura de diretórios no projeto FileManager com a interface <strong>FileManager.Interfaces.IDirectoryReader</strong><br>
        &nbsp;
    </p>
    <h5 style="margin-left:40px;">
        <strong>2 - Preview e Renomeação de arquivos</strong>
    </h5>
        ![image](https://github.com/user-attachments/assets/c1fd3e69-cc60-474e-b797-2761385c9b0e)
        ![Classe UML (1)](https://github.com/user-attachments/assets/fa7cafb2-8f2e-4e80-955e-f29443c52fc3)
    <h5 style="margin-left:40px;">
        Interfaces&nbsp;
    </h5>
    <p style="margin-left:40px;">
        <strong>ITabControlWrapper : </strong>Esta interface recebe todas as Tabs de file preview e rename e envia um IOperationContract para a camada de serviço retornar a operação de preview ou rename de arquivos.<br>
        <strong>ITabControl : </strong>Esta interface&nbsp;<br>
        <br>
        &nbsp;
    </p>
</article>
