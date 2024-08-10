Vagrant.configure("2") do |config|
    config.vm.box = "gusztavvargadr/docker-linux"
    config.vm.network "private_network", ip: "192.168.20.48"
    config.vm.synced_folder ".", "/vagrant"
end
