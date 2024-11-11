# Tipos de Serviço de Nuvem 🏗️

## IaaS, PaaS e SaaS:

<strong>IaaS(Infrastructure as a Service)</strong>: Modelo de Infraestrutura como Serviço, onde o provedor de nuvem fornece recursos básicos de infraestrutura, como servidores virtuais, armazenamento, redes e sistemas operacionais. Os usuários têm <strong>flexibilidade para configurar e gerenciar essa infraestrutura de acordo com suas necessidades</strong>. Ideal para empresas que precisam de controle total sobre suas configurações de TI, como servidores para aplicativos personalizados. Exemplos incluem Azure Virtual Machines e armazenamento em nuvem.

<strong>PaaS (Platform as a Service)</strong>: Oferece um <strong>ambiente completo de desenvolvimento e implementação</strong>, eliminando a complexidade da gestão de hardware e sistemas operacionais. Com o PaaS, os desenvolvedores podem criar, testar, implantar e gerenciar aplicativos rapidamente, usando ferramentas fornecidas, como o Azure App Services, facilitando o desenvolvimento de aplicações web com menos esforço de configuração.

<strong>SaaS (Software as a Service)</strong>: No modelo de Software como Serviço, os <strong>usuários acessam aplicações completas</strong> por meio da Internet, geralmente via navegador, sem precisar se preocupar com a manutenção ou infraestrutura por trás delas. O provedor cuida de tudo, incluindo segurança, atualizações e gerenciamento. Exemplos incluem Microsoft 365 e Azure DevOps.

## Modelo de Responsabilidade Compartilhada:

Este modelo define as responsabilidades da Azure e do cliente, ajudando a esclarecer quem é responsável por quê em relação à segurança e gerenciamento dos serviços de nuvem.

- <strong>Provedor de nuvem (Azure)</strong>: é responsável pela segurança da infraestrutura física, serviços de base, hardware e algumas configurações do serviço.
- <strong>Cliente</strong>: Responsável pelo que utiliza e configura na nuvem, como segurança dos dados, configuração de identidade de usuários, aplicativos hospedados e níveis de acesso.

  #### Exemplo:

  Ao usar uma máquina virtual (IaaS) na Azure, a Microsoft é responsável por manter o hardware seguro, enquanto o cliente deve gerenciar o sistema operacional, patches de segurança e configurações de acesso.
