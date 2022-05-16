<template>
  <li class="font-medium text-lg text-gray-600">
    <NuxtLink :class="[activeLink, collapsedLink]" :to="linkItem.href"
              class="flex items-center gap-2.5 p-4 rounded transition duration-300 ease-in-out hover:bg-gray-200">
      <span :class="linkItem.icon"></span>
      <div v-if="!this.$parent.isCollapsed" class="">
        <p>{{ linkItem.text }}</p>
      </div>
    </NuxtLink>
  </li>
</template>

<script>
export default {
  props: {
    linkItem: Object
  },
  computed: {
    activeLink() {
      return this.$route.path == this.linkItem.href ? 'bg-gray-100 text-black' : '';
    },
    collapsedLink() {
      return this.$parent.isCollapsed ? 'justify-center' : '';
    }
  }
}
</script>
