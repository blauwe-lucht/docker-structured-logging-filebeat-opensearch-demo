Vagrant.configure("2") do |config|
    config.vm.box = "gusztavvargadr/docker-linux"
    config.vm.network "private_network", ip: "192.168.20.48"
    config.vm.synced_folder ".", "/vagrant"

    config.vm.provision "shell", inline: <<-SHELL
        echo Installing docker-compose...
        apt-get install -y docker-compose

        echo Fixing DNS issue...
        cat << EOF > /etc/systemd/resolved.conf
[Resolve]
DNS=8.8.8.8
EOF
        systemctl restart systemd-resolved

        echo Done!
    SHELL
end
