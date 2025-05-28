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
        1. Open file renamer
    </h2>
    <p style="margin-left:40px;" data-foo="bar">
        Queremos uma aplicação que dê uma ferramenta gratuita e de código aberto para auxiliar operações comuns do dia a dia de quem precisa organizar uma grande quantidades de arquivos.<br>
        [<a src="https://drive.google.com/file/d/155v-SYu8Wtzxqv2hS4F0Yms0r-RD_5Ul/view?usp=sharing">Download</a>](https://drive.google.com/file/d/155v-SYu8Wtzxqv2hS4F0Yms0r-RD_5Ul/view?usp=sharing)
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
    <p>
        <img src="https://github.com/user-attachments/assets/b18723d9-1ab0-43e2-94b6-94fe4bba15eb">
    </p>
    <p style="margin-left:40px;">
        Implemente novos tipos de filtros enviando um evento para o método privado : <strong>searchFilter_Changed </strong>da classe <strong>Presentation.Main,</strong><br>
        adicione um novo tipo de Enum em <strong>ApplicationService.Enum.Main_SearchFilter</strong> e implemente uma nova leitura de diretórios no projeto FileManager com a interface <strong>FileManager.Interfaces.IDirectoryReader</strong><br>
        &nbsp;
    </p>
    <h5 style="margin-left:40px;">
        <strong>2 - Preview e Renomeação de arquivos</strong>
    </h5>
    <p>
        <img src="https://github.com/user-attachments/assets/c1fd3e69-cc60-474e-b797-2761385c9b0e">
    </p>
    <p>
        <img src="https://github.com/user-attachments/assets/fa7cafb2-8f2e-4e80-955e-f29443c52fc3">
    </p>
    <h5 style="margin-left:40px;">
        Interfaces&nbsp;
    </h5>
    <p style="margin-left:40px;">
        <strong>ITabControlWrapper :I</strong>nterface que recebe todas as Tabs de file preview e rename e envia um IOperationContract para a camada de serviço retornar a operação de preview ou rename de arquivos.<br>
        &nbsp;
    </p>
    <p style="margin-left:40px;">
        <strong>ITabControl : I</strong>nterface&nbsp;que é utilizada na design pattern Strategy com finalidade de delegar a opções escolhidas de reanomeação de arquivo e convertelas para a interface IOperationContract<br>
        &nbsp;
    </p>
    <p style="margin-left:40px;">
        <strong>IOperationContract </strong>: É o contralo estabelecido para organizar os dados necessários para solicitar uma utilização de renomeação de arquivos fornecida pela camada de serviço, todas as chamadas de file rename devem implementar esta interface.
    </p>
    <p style="margin-left:40px;">
        &nbsp;
    </p>
    <h5 style="margin-left:40px;">
        3 - Rollback de renomeação&nbsp;
    </h5>
    <p style="margin-left:40px;">
        A implementação atual envia o nome do diretório e refaz a ultima operação armazenada no memento do File Manager
    </p>
    <p style="margin-left:40px;">
        &nbsp;
    </p>
    <p style="margin-left:40px;">
        &nbsp;
    </p>
    <h3 style="margin-left:40px;">
        Micro Serviço File Renamer
    </h3>
    <p>
        <img src="https://github.com/user-attachments/assets/f380bb87-3e21-4406-b935-4aa4880218de">
    </p>
    <p style="margin-left:40px;">
        Todas as operações que modificam arquivos devem passar pelo Memento antes de serem iniciadas, isto inclui também operações de Rollback.<br>
        Operações referentes á apenas leitura de arquivos podem ser isoladas em uma classe separada e não precisam passar pelo memento.<br>
        &nbsp;
    </p>
    <h2 style="margin-left:40px;">
        <br>
        4. Post mortem
    </h2>
    <p style="margin-left:40px;">
        Após a conclusão do projeto foi possível ver problemas comuns em projetos pequenos com a finalidade de leitura e escrita de arquivos.<br>
        &nbsp;
    </p>
    <p style="margin-left:40px;">
        <strong>Planejamento para varias interfaces de usuário :&nbsp;</strong><br>
        Foi &nbsp;possível verificar que embora a leitura e escrita de arquivos utiliza-se uma classe comum para abstrair suas funcionalidade de alto nível, a implementação carece de formas de substituir sua implementação, desta forma não foi possível trocar o metodo de acesso á dados sem comprometer todos as implementações já existentes.<br>
        Isto foi notado após implementar toda a interface com .NET Maui e ter debugado apenas no windows, quando depurado em android, &nbsp;já não é mais possível ler ou modificar arquivos com a mesma classe <strong>FileInfo </strong>e <strong>DirectoryInfo</strong>.&nbsp;<br>
        <br>
        <strong>Delegar parte da logica da interface de usuário para a camada de serviço :&nbsp;</strong><br>
        A camada de serviço ao decorrer do projeto acabou fazendo parte da lógica de delegação de dados da interface de usuário,<br>
        desta forma a interface do .NET Maui já nasceu com um modelo para ser atendido.<br>
        <br>
        <strong>Modificação de última hora na forma de ler arquivos :&nbsp;</strong><br>
        O projeto iniciou com o acesso á leitura de arquivos com uma única fonte da verdade (SSOT), e foi possível de última hora definir a Identidade do arquivo como uma TimeStamp em vez do nome completo do arquivo e diretório, &nbsp;isto permitiu implementar o rollback de versão com um ponto negativo: modificando a data de criação do arquivo para criar uma identidade única para este arquivo com TimeStamp.Ticks .<br>
        &nbsp;
    </p>
</article>
